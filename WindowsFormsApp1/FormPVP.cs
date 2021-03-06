﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Media;
using System.Resources;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class FormPVP : Form
    {
        #region Properties
        QuanLyBanCo BanCo;
        QuanLyTime timeG;
        SocketManager socket;

        GameSound gameSound = new GameSound();

        //---FOR CHATTING---
        private TcpClient client;
        public StreamReader STR;
        public StreamWriter STW;
        public string recieve;
        public String TextToSend;
        TcpListener listener;
        //------------------

        #endregion

        public FormPVP()
        {
            InitializeComponent();
            
            

            Control.CheckForIllegalCrossThreadCalls = false;

            this.AcceptButton = sendButton;

            NewGame_Btn.Enabled = false;

            socket = new SocketManager();

            timeG = new QuanLyTime();
            BanCo = new QuanLyBanCo(BanCo_pnl,timeG, this, PlayerMark_pictureBox, textBox_PlayerName1);

            BanCo.EndedGame += BanCo_EndedGame;
            BanCo.PlayerMarked += BanCo_PlayerMarked;
            BanCo.EndedGameRandom += BanCo_EndedGameRandom;
            BanCo.Timestop += BanCo_Timestop;

            NewGame();

            //label_GameTime.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
            //timer_Game.Start();

            //timer_Player1.Start();

            BanCo_pnl.Enabled = false;
        }

        private void BanCo_Timestop(object sender, EventArgs e)
        {
            timer_Player1.Stop();
            timer_Game.Stop();
            timeG.Time1 = 10;
            label_timePlayer1.Text = "10";
            label_GameTime.Text = "0:00";
        }



        #region Event
        private void BanCo_EndedGameRandom(object sender, EventArgs e)
        {
            EndGameRandom();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void BanCo_PlayerMarked(object sender, ButtonClickEvent e)
        {
            timer_Player1.Start();
            timer_Game.Start();
            timeG.Time1 = 10;
            label_timePlayer1.Text = "10";
            
            BanCo_pnl.Enabled = false;
            BanCo.IsRandomTurn = false;

            socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));
            
            Listen();
        }

        private void BanCo_EndedGame(object sender, EventArgs e)
        {
            EndGame();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void timer_Game_Tick(object sender, EventArgs e)
        {
            if (timeG.Sec >= 0 && timeG.Sec < 59)
            {
                if (timeG.Sec < 9)
                {
                    timeG.Sec++;
                    label_GameTime.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
                }
                else
                {
                    timeG.Sec++;
                    label_GameTime.Text = timeG.Minute.ToString() + ":" + timeG.Sec.ToString();
                }
            }
            else
            {
                timeG.Sec = 0;
                timeG.Minute++;
                label_GameTime.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
            }
        }

        private void timer_Player1_Tick(object sender, EventArgs e)
        {
            if (timeG.Time1 > 0)
            {
                timeG.Time1--;
                label_timePlayer1.Text = timeG.Time1.ToString();
            }
            else
            {
                if (BanCo.IsRandomTurn == true)
                {
                    BanCo.HamDanhRandom();
                    BanCo.IsRandomTurn = false;
                }
                timeG.Time1 = Constant.timePlayer1;
            }

        }

        private void KetNoiLAN_Btn_Click(object sender, EventArgs e)
        {
            socket.IP = textBox_PlayerIP1.Text;

            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                BanCo_pnl.Enabled = true;

                socket.CreateServer();

                //Listen();

                //--FOR CHATTING--
                Thread listenThread = new Thread(() =>
                {
                    listener = new TcpListener(IPAddress.Any, 6969);
                    listener.Start();
                    client = listener.AcceptTcpClient();
                    STR = new StreamReader(client.GetStream());
                    STW = new StreamWriter(client.GetStream());
                    STW.AutoFlush = true;

                    backgroundWorker1.RunWorkerAsync();
                    backgroundWorker2.WorkerSupportsCancellation = true;

                    ChatTextBox.AppendText("Client was connected" + "\r\n");
                });
                listenThread.IsBackground = true;
                listenThread.Start();
                //----------------
            }
            else
            {
                socket.isServer = false;
                BanCo_pnl.Enabled = false;
                
                Listen();

                //--FOR CHATTING--
                Thread listenThread = new Thread(() =>
                {
                    client = new TcpClient();
                    IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(textBox_PlayerIP1.Text), 6969);

                    try
                    {
                        client.Connect(IpEnd);

                        if (client.Connected)
                        {
                            ChatTextBox.AppendText("Connected to server" + "\r\n");
                            STW = new StreamWriter(client.GetStream());
                            STR = new StreamReader(client.GetStream());
                            STW.AutoFlush = true;
                            backgroundWorker1.RunWorkerAsync();
                            backgroundWorker2.WorkerSupportsCancellation = true;

                        }
                    }
                    catch
                    {
                        MessageBox.Show("Người chơi host đã thoát!!", "THÔNG BÁO");
                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();

                
                //----------------
            }

            KetNoiLAN_Btn.Enabled = false;
        }

        //--FOR CHATTING--
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (client.Connected)
            {
                try
                {
                    recieve = STR.ReadLine();
                    this.ChatTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatTextBox.AppendText("Friend (" + DateTime.Now.ToString() + "): " + recieve + "\r\n");
                    }));
                    recieve = "";
                }
                catch
                {
                    
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (client.Connected)
                {
                    STW.WriteLine(TextToSend);
                    this.ChatTextBox.Invoke(new MethodInvoker(delegate ()
                    {
                        ChatTextBox.AppendText("You (" + DateTime.Now.ToString() + "): " + TextToSend + "\r\n");
                    }));
                }
                else
                {
                    MessageBox.Show("Không có người chơi nào trong phòng chat", "THÔNG BÁO");
                }
                backgroundWorker2.CancelAsync();
            }
            catch
            {
                MessageBox.Show("Chưa có người chơi nào được kết nối", "THÔNG BÁO");
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if (SendTextBox.Text != "")
            {
                TextToSend = SendTextBox.Text;
                backgroundWorker2.RunWorkerAsync();
            }
            SendTextBox.Text = "";
        }  
        //----------------



        private void FormPVP_Shown(object sender, EventArgs e)
        {
            textBox_PlayerIP1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(textBox_PlayerIP1.Text))
            {
                textBox_PlayerIP1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }    
        }

        private void NewGame_Btn_Click(object sender, EventArgs e)
        {
            NewGame();
            socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
            BanCo_pnl.Enabled = true;
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                //System.Windows.Forms.Application.ExitThread();
                //Environment.Exit(Environment.ExitCode);
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }

                try
                {
                    //STW.Close();
                    //STR.Close();
                    listener.Stop();
                    client.Close();
                    socket.Close();
                }
                catch
                {
                    
                }
                gameSound.StopGamePlaySound();
                gameSound.PlayMenuSound();
                this.Close();
            }
        }
        #endregion

        #region Methods

        void EndGameRandom()
        {
            timer_Game.Stop();
            timer_Player1.Stop();
            
            BanCo_pnl.Enabled = false;
            if (BanCo.CurrentPlayer == 0)
            {
                MessageBox.Show(BanCo.Player[0].Name + " win!");
            }
            else
            {
                MessageBox.Show(BanCo.Player[1].Name + " win!");
            }
            NewGame_Btn.Enabled = true;
        }

        void EndGame()
        {
            timer_Game.Stop();
            timer_Player1.Stop();
            BanCo_pnl.Enabled = false;
            if (BanCo.CurrentPlayer == 0)
            {
                MessageBox.Show(BanCo.Player[1].Name + " win!");
            }
            else
            {
                MessageBox.Show(BanCo.Player[0].Name + " win!");
            }
            NewGame_Btn.Enabled = true;
        }

        void NewGame()
        {
            NewGame_Btn.Enabled = false;
            timer_Game.Stop();
            timer_Player1.Stop();

            BanCo.VeBanCo();

            timeG.Sec = 0;
            timeG.Minute = 0;
            timeG.Time1 = 10;
            

            label_GameTime.Text = "0:00";
            label_timePlayer1.Text = "10";

            //timer_Game.Start();
            //timer_Player1.Start();
        }

        

        void Listen()
        {
            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch (Exception e)
                {

                }
            });
            listenThread.IsBackground = true;
            listenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;
                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        BanCo_pnl.Enabled = false;
                    }));
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        BanCo.IsRandomTurn = true;
                        label_timePlayer1.Text = Constant.timePlayer1.ToString();
                        BanCo_pnl.Enabled = true;
                        timeG.Time1 = 10;
                        label_timePlayer1.Text = "10";
                        timer_Player1.Start();
                        timer_Game.Start();
                        BanCo.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    break;
                case (int)SocketCommand.END_GAME:
                    MessageBox.Show("Đã kết thúc game");
                    break;
                case (int)SocketCommand.QUIT:
                    timer_Game.Stop();
                    timer_Player1.Stop();
                    label_GameTime.Text = "0:00";
                    label_timePlayer1.Text = "10";
                    timeG.Time1 = 10;
                    NewGame_Btn.Enabled = true;

                    try
                    {
                        STW.Close();
                        STR.Close();
                        listener.Stop();
                        client.Close();
                        socket.Close();
                    }
                    catch
                    {
                        
                    }
                    ChatTextBox.Text = "";
                    ChatTextBox.Text = "Đối phương đã thoát!!!";
                    MessageBox.Show("Người chơi đối phương đã thoát!!", "THÔNG BÁO");
                    gameSound.StopGamePlaySound();
                    gameSound.PlayMenuSound();
                    this.Close();
                    break;
                case (int)SocketCommand.HAVE_CLIENT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        MessageBox.Show("Co client ket noi");
                    }));
                    break;
                default:
                    break;
            }
            Listen();
        }
        #endregion

        private void FormPVP_Load(object sender, EventArgs e)
        {
            gameSound.PlayGameSound();
        }

        private void Mute_Button_Click(object sender, EventArgs e)
        {
            gameSound.PlayGameSound();

            Mute_Button.Visible = false;
            Sound_Button.Visible = true;
        }

        private void Sound_Button_Click(object sender, EventArgs e)
        {
            gameSound.StopGamePlaySound();


            Sound_Button.Visible = false;
            Mute_Button.Visible = true;
        }
    }
}
