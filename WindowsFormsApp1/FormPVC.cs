using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp1
{
    public partial class FormPVC : Form
    {
        QuanLyBanCoPVC BanCo;
        QuanLyTime timeG;

        private static int columns, rows;
        public int[,] vtMap;


        GameSound gameSound = new GameSound();

        public FormPVC()
        {
            InitializeComponent();

            timeG = new QuanLyTime();
            BanCo = new QuanLyBanCoPVC(BanCo_pnl, timeG, this,playerName_TextBox,pictureBox1);
            playerName_TextBox.Text = BanCo.Player[0].Name;
            pictureBox1.Image = BanCo.Player[0].Mark;
            
            BanCo.EndedGame += BanCo_EndedGame;
            BanCo.PlayerMarked += BanCo_PlayerMarked;
            BanCo.EndedGameRandom += BanCo_EndedGameRandom;

            columns = Constant.ChieuRongBanCo;
            rows = Constant.ChieuCaoBanCo;

            vtMap = new int[rows + 2, columns + 2];

            BanCo.VeBanCo();

            BanCo.CurrentPlayer = 0;
        }

        private void BanCo_PlayerMarked(object sender, EventArgs e)
        {
            timer_Player.Start();
            timer_Game.Start();
            timeG.Time1 = Constant.timePlayer1;
            timerPlayer_Label.Text = Constant.timePlayer1.ToString();
        }

        public void BanCo_EndedGameRandom(object sender, EventArgs e)
        {
            EndGame();
        }

        public void BanCo_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        void EndGame()
        {
            timer_Game.Stop();
            timer_Player.Stop();

            BanCo_pnl.Enabled = false;
            BanCo.ChangeCurrentPlayer();
            if (BanCo.CurrentPlayer == 0)
            {
                MessageBox.Show(BanCo.Player[1].Name + " win!");
            }
            else
            {
                MessageBox.Show(BanCo.Player[0].Name + " win!");
            }
        }

        #region AI
        private int[] Attack = new int[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
        private int[] Defense = new int[7] { 0, 3, 27, 99, 729, 6561, 59049 };

        private void PutChess(int x, int y)
        {
            BanCo.Marking(BanCo.Matrix[x][y]);
            vtMap[x, y] = 2;
            if (BanCo.IsEndGame(BanCo.Matrix[x][y])) EndGame();

            BanCo.ChangeCurrentPlayer();
        }

        public void CptFindChess()
        {
            long max = 0;
            int imax = 1, jmax = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                    if (vtMap[i, j] == 0)
                    {
                        long temp = Caculate(i, j);
                        if (temp > max)
                        {
                            max = temp;
                            imax = i; jmax = j;
                        }
                    }
            }
            PutChess(imax, jmax);
        }
        private long Caculate(int x, int y)
        {
            return EnemyChesses(x, y) + ComputerChesses(x, y);
        }
        private long ComputerChesses(int x, int y)
        {
            int i = x - 1, j = y;
            int column = 0, row = 0, mdiagonal = 0, ediagonal = 0;
            int sc_ = 0, sc = 0, sr_ = 0, sr = 0, sm_ = 0, sm = 0, se_ = 0, se = 0;
            while (i >= 0 &&  vtMap[i, j] == 2)
            {
                column++;
                i--;
            }
            if (i >= 0 && vtMap[i, j] == 0) sc_ = 1;
            i = x + 1;
            while (vtMap[i, j] == 2 && i <= rows)
            {
                column++;
                i++;
            }
            if (vtMap[i, j] == 0) sc = 1;
            i = x; j = y - 1;
            while (j>=0 && vtMap[i, j] == 2)
            {
                row++;
                j--;
            }
            if (j>=0 && vtMap[i, j] == 0) sr_ = 1;
            j = y + 1;
            while (vtMap[i, j] == 2 && j <= columns)
            {
                row++;
                j++;
            }
            if (vtMap[i, j] == 0) sr = 1;
            i = x - 1; j = y - 1;
            while (i >= 0 && j >= 0 && vtMap[i, j] == 2)
            {
                mdiagonal++;
                i--;
                j--;
            }
            if (i >= 0 && j >= 0 && vtMap[i, j] == 0) sm_ = 1;
            i = x + 1; j = y + 1;
            while (vtMap[i, j] == 2 && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            if (vtMap[i, j] == 0) sm = 1;
            i = x - 1; j = y + 1;
            while (i >= 0 && vtMap[i, j] == 2 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            if (i>=0 && vtMap[i, j] == 0) se_ = 1;
            i = x + 1; j = y - 1;
            while (j>=0 && vtMap[i, j] == 2 && i <= rows)
            {
                ediagonal++;
                i++;
                j--;
            }
            if (j>=0 && vtMap[i, j] == 0) se = 1;

            if (column == 4) column = 5;
            if (row == 4) row = 5;
            if (mdiagonal == 4) mdiagonal = 5;
            if (ediagonal == 4) ediagonal = 5;

            if (column == 3 && sc == 1 && sc_ == 1) column = 4;
            if (row == 3 && sr == 1 && sr_ == 1) row = 4;
            if (mdiagonal == 3 && sm == 1 && sm_ == 1) mdiagonal = 4;
            if (ediagonal == 3 && se == 1 && se_ == 1) ediagonal = 4;

            if (column == 2 && row == 2 && sc == 1 && sc_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (column == 2 && mdiagonal == 2 && sc == 1 && sc_ == 1 && sm == 1 && sm_ == 1) column = 3;
            if (column == 2 && ediagonal == 2 && sc == 1 && sc_ == 1 && se == 1 && se_ == 1) column = 3;
            if (row == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (row == 2 && ediagonal == 2 && se == 1 && se_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (ediagonal == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && se == 1 && se_ == 1) column = 3;

            long Sum = Attack[row] + Attack[column] + Attack[mdiagonal] + Attack[ediagonal];

            return Sum;
        }


        private long EnemyChesses(int x, int y)
        {
            int i = x - 1, j = y;
            int sc_ = 0, sc = 0, sr_ = 0, sr = 0, sm_ = 0, sm = 0, se_ = 0, se = 0;
            int column = 0, row = 0, mdiagonal = 0, ediagonal = 0;
            //
            while (i>=1 && vtMap[i, j] == 1)
            {
                column++;
                i--;
            }
            if (i >= 0 && vtMap[i, j] == 0) sc_ = 1;
            i = x + 1;
            while (vtMap[i, j] == 1 && i <= rows)
            {
                column++;
                i++;
            }
            if (vtMap[i, j] == 0) sc = 1;
            i = x; j = y - 1;
            //
            while (j >= 1 && vtMap[i, j] == 1)
            {
                row++;
                j--;
            }
            if (j>=0 && vtMap[i, j] == 0) sr_ = 1;
            j = y + 1;
            while (vtMap[i, j] == 1 && j <= columns)
            {
                row++;
                j++;
            }
            if (vtMap[i, j] == 0) sr = 1;
            i = x - 1; j = y - 1;
            while (i >= 1 && j >= 1 && vtMap[i, j] == 1)
            {
                mdiagonal++;
                i--;
                j--;
            }
            if (i >= 0 && j >= 0 && vtMap[i, j] == 0) sm_ = 1;
            i = x + 1; j = y + 1;
            while (vtMap[i, j] == 1 && i <= rows && j <= columns)
            {
                mdiagonal++;
                i++;
                j++;
            }
            if (vtMap[i, j] == 0) sm = 1;
            i = x - 1; j = y + 1;
            while (i >= 1 && vtMap[i, j] == 1 && j <= columns)
            {
                ediagonal++;
                i--;
                j++;
            }
            if (i>=0 && vtMap[i, j] == 0) se_ = 1;
            i = x + 1; j = y - 1;
            while (j >= 1 && vtMap[i, j] == 1 && i <= rows)
            {
                ediagonal++;
                i++;
                j--;
            }
            if (j>=0 && vtMap[i, j] == 0) se = 1;

            if (column == 4) column = 5;
            if (row == 4) row = 5;
            if (mdiagonal == 4) mdiagonal = 5;
            if (ediagonal == 4) ediagonal = 5;

            if (column == 3 && sc == 1 && sc_ == 1) column = 4;
            if (row == 3 && sr == 1 && sr_ == 1) row = 4;
            if (mdiagonal == 3 && sm == 1 && sm_ == 1) mdiagonal = 4;
            if (ediagonal == 3 && se == 1 && se_ == 1) ediagonal = 4;

            if (column == 2 && row == 2 && sc == 1 && sc_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (column == 2 && mdiagonal == 2 && sc == 1 && sc_ == 1 && sm == 1 && sm_ == 1) column = 3;
            if (column == 2 && ediagonal == 2 && sc == 1 && sc_ == 1 && se == 1 && se_ == 1) column = 3;
            if (row == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (row == 2 && ediagonal == 2 && se == 1 && se_ == 1 && sr == 1 && sr_ == 1) column = 3;
            if (ediagonal == 2 && mdiagonal == 2 && sm == 1 && sm_ == 1 && se == 1 && se_ == 1) column = 3;
            long Sum = Defense[row] + Defense[column] + Defense[mdiagonal] + Defense[ediagonal];

            return Sum;
        }
        #endregion

        private void newGame_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có tạo game mới ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                timer_Game.Stop();
                timer_Player.Stop();

                BanCo.VeBanCo();

                timeG.Sec = 0;
                timeG.Minute = 0;
                timeG.Time1 = 10;


                timerGame_Label.Text = "0:00";
                timerPlayer_Label.Text = timeG.Time1.ToString();
            }
        }

        private void timer_Game_Tick(object sender, EventArgs e)
        {
            if (timeG.Sec >= 0 && timeG.Sec < 59)
            {
                if (timeG.Sec < 9)
                {
                    timeG.Sec++;
                    timerGame_Label.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
                }
                else
                {
                    timeG.Sec++;
                    timerGame_Label.Text = timeG.Minute.ToString() + ":" + timeG.Sec.ToString();
                }
            }
            else
            {
                timeG.Sec = 0;
                timeG.Minute++;
                timerGame_Label.Text = timeG.Minute.ToString() + ":0" + timeG.Sec.ToString();
            }
        }

        private void timer_Player_Tick(object sender, EventArgs e)
        {
            if(timeG.Time1 > 0)
            {
                timeG.Time1--;
                timerPlayer_Label.Text = timeG.Time1.ToString();
            }
            else
            { 
                BanCo.HamDanhRandom();
                timeG.Time1 = Constant.timePlayer1;
            }
        }

        private void quit_Button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ?", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Dispose();
            }

            gameSound.StopGamePlaySound();
            gameSound.PlayMenuSound();
        }
        
    }
}
