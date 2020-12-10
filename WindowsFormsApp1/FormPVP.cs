using System;
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

namespace WindowsFormsApp1
{
    public partial class FormPVP : Form
    {
        #region Properties
        QuanLyBanCo BanCo;
        QuanLyTime timeG;
        SocketManager socket;
        
        #endregion

        public FormPVP()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            NewGame_Btn.Enabled = false;

            socket = new SocketManager();

            timeG = new QuanLyTime();
            BanCo = new QuanLyBanCo(BanCo_pnl,timeG,this, PlayerMark_pictureBox, textBox_PlayerName1);

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
            }
            else
            {
                socket.isServer = false;
                BanCo_pnl.Enabled = false;
                
                Listen();
            }
            KetNoiLAN_Btn.Enabled = false;
        }

        

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
                this.Dispose(true);
                //Environment.Exit(Environment.ExitCode);
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
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
                    MessageBox.Show("Người chơi đã thoát!!");
                    break;
                case (int)SocketCommand.HAVE_CLIENT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        BanCo_pnl.Enabled = true;
                    }));
                    break;
                default:
                    break;
            }
            Listen();
        }
        #endregion
    }
}
