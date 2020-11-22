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
            socket = new SocketManager();

            timeG = new QuanLyTime();
            BanCo = new QuanLyBanCo(BanCo_pnl,timeG,this);

            BanCo.VeBanCo();
            label_GameTime.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
            timer_Game.Start();

            timer_Player1.Start();
        }

        
        private void timer_Game_Tick(object sender, EventArgs e)
        {
            if(timeG.Sec >= 0 && timeG.Sec < 59)
            { 
                if(timeG.Sec < 9)
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
               // pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                //pnlChessBoard.Enabled = false;
                Listen();
            }
        }

        private void FormPVP_Shown(object sender, EventArgs e)
        {
            textBox_PlayerIP1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(textBox_PlayerIP1.Text))
            {
                textBox_PlayerIP1.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
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
                    break;
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                     //   prcbCoolDown.Value = 0;
                      //  pnlChessBoard.Enabled = true;
                      //  tmCoolDown.Start();
                     //   ChessBoard.OtherPlayerMark(data.Point);
                    }));
                    break;
                case (int)SocketCommand.UNDO:
                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                case (int)SocketCommand.QUIT:
                    break;
                default:
                    break;
            }

            Listen();
        }
    }
}
