using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPVP : Form
    {
        #region Properties
        QuanLyBanCo BanCo;
        QuanLyTime timeG;
        #endregion
        public FormPVP()
        {
            InitializeComponent();

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
            if(timeG.Time1 > 0)
            {
                timeG.Time1--;
                label_timePlayer1.Text = timeG.Time1.ToString();
            }
            else BanCo.ChangeTimeCounter();
        }

        private void timer_Player2_Tick(object sender, EventArgs e)
        {
            if (timeG.Time2 > 0)
            {
                timeG.Time2--;
                label_timePlayer2.Text = timeG.Time2.ToString();
            }
            else BanCo.ChangeTimeCounter();
        }
    }
}
