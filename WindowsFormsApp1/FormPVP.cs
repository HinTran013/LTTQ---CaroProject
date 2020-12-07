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
            BanCo = new QuanLyBanCo(BanCo_pnl,timeG,this);

            BanCo.EndedGame += BanCo_EndedGame;
            BanCo.PlayerMarked += BanCo_PlayerMarked;
            BanCo.EndedGameRandom += BanCo_EndedGameRandom;
            BanCo.RandomMarked += BanCo_RandomMarked;

            NewGame();

            //label_GameTime.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
            //timer_Game.Start();

            //timer_Player1.Start();

            BanCo_pnl.Enabled = false;
        }



        #region Event
        private void BanCo_RandomMarked(object sender, ButtonClickEvent e)
        {
            BanCo.ChangeTimeCounter();
            BanCo_pnl.Enabled = false;
            socket.Send(new SocketData((int)SocketCommand.SEND_RANDOMPOINT, "", e.ClickedPoint));

            Listen();
        }

        private void BanCo_EndedGameRandom(object sender, EventArgs e)
        {
            EndGameRandom();
            socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }

        private void BanCo_PlayerMarked(object sender, ButtonClickEvent e)
        {
            BanCo.ChangeTimeCounter();
            BanCo_pnl.Enabled = false;
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
                BanCo.HamDanhRandom();
                BanCo.ChangeTimeCounter();
            }

        }

        private void timer_Player2_Tick(object sender, EventArgs e)
        {
            if (timeG.Time2 > 0)
            {
                timeG.Time2--;
                label_timePlayer2.Text = timeG.Time2.ToString();
            }
            else
            {
                BanCo.HamDanhRandom();
                BanCo.ChangeTimeCounter();
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

            //BanCo_pnl.Enabled = true;
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
            timer_Player2.Stop();
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
            timer_Player2.Stop();
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
            timer_Player2.Stop();

            BanCo.VeBanCo();

            timeG.Sec = 0;
            timeG.Minute = 0;
            timeG.Time1 = 10;
            timeG.Time2 = 10;

            label_GameTime.Text = "0:00";
            label_timePlayer1.Text = "10";
            label_timePlayer2.Text = "10";

            timer_Game.Start();
            timer_Player1.Start();
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
                        label_timePlayer1.Text = Constant.timePlayer1.ToString();
                        BanCo_pnl.Enabled = true;
                        timer_Player1.Start();
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
                    timer_Player2.Stop();
                    MessageBox.Show("Người chơi đã thoát!!");
                    break;
                case (int)SocketCommand.SEND_RANDOMPOINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        label_timePlayer1.Text = Constant.timePlayer1.ToString();
                        BanCo_pnl.Enabled = true;
                        timer_Player1.Start();
                        BanCo.HamDanhRandom();
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
