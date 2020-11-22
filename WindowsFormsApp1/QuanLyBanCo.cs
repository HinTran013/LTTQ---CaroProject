using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    
    public class QuanLyBanCo
    {
        #region Properties
        
        private Panel BanCo;
        private QuanLyTime timeG;
        private FormPVP FormMain;
        private bool MarkOrNot;
        private Random DanhDauRandom;

        private List<Player> player;
        public List<Player> Player
        {
            get { return player; }
            set { player = value; }
        }

        private int currentPlayer;//currentPlayer dung de xac dinh player hien tai.

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        private TextBox playerName;
        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        //Lưu trữ 1 list mà trong đó mỗi phần tử của list cũng là 1 list các button
        //Dùng để truy xuất tới nút nhấn trên bàn cờ để xử lý thắng thua
        private List<List<Button>> Matrix;

        #endregion

        #region Initialize

        public QuanLyBanCo(Panel BanCo,QuanLyTime timeG,FormPVP FormMain)
        {
            MarkOrNot = false;
            DanhDauRandom = new Random();

            this.BanCo = BanCo;
            this.timeG = timeG;
            this.FormMain = FormMain;

            this.PlayerName = playerName;

            this.Player = new List<Player>();

            this.Player.Add(new Player("PLAYER 1", Resources.red_x_transparent_png_3));

            this.Player.Add(new Player("PLAYER 2", Resources.n1530354));

            //Khoi tao ca 2 player va dat player 1 la player choi truoc.
            CurrentPlayer = 0;
        }

        #endregion

        #region Methods

        public void VeBanCo()
        {
            //Khởi tạo đối tượng matrix
            Matrix = new List<List<Button>>();

            //Button truoc cua moi button khi tao
            Button PreButton = new Button() { Width = 0, Location = new Point(0, 0) };

            //Vong lap de tao ban co
            for (int i = 0; i < Constant.ChieuCaoBanCo; i++)
            {

                //Mỗi hàng của bàn cờ sẽ là một list các button (do i chạy theo chiều cao của bàn cờ)
                //ở đây sẽ khởi tạo phần tử thứ i của matrix, đồng thời phần tử thứ i này sẽ là 1 list các button
                //ĐỒNG NGHĨA VỚI VIỆC MAXTRIX[I] LÀ 1 LIST BUTTON
                Matrix.Add(new List<Button>());


                for (int j = 0; j < Constant.ChieuRongBanCo; j++)
                {
                    Button btn = new Button();

                    btn.Width = Constant.ChieuCaoConCo;
                    btn.Height = Constant.ChieuCaoConCo;
                    btn.Location = new Point(PreButton.Location.X + PreButton.Width, PreButton.Location.Y);
                    //tag này cho biết rằng button đang được lưu ở hàng thứ i
                    btn.Tag = i.ToString();
                    btn.BackColor = System.Drawing.Color.FromArgb(235, 235, 224);
                    //kich thuoc cua anh qua lon' nen phai chinh kich co cua anh cho vua` voi button
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    //Tao event khi nhan' vao button
                    btn.Click += Btn_Click;

                    //thêm các button vào panel
                    BanCo.Controls.Add(btn);

                    //thêm button vào list thứ i của matrix
                    Matrix[i].Add(btn);

                    //Gan button moi tao lam button truoc cua button chuan bi tao
                    PreButton = btn;
                }

                //Sau khi tao xong 1 hang trong ban co, thi set X cua pre button ve 0
                //Y cua prebutton duoc day xuong 1 doan = chieu rong cua 1 o
                PreButton.Location = new Point(0, PreButton.Location.Y + Constant.ChieuRongConCo);
                PreButton.Width = 0;
                PreButton.Height = 0;
            }
            this.BanCo.Show();
        }


        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            //Fix loi dau X khi truy cap Resource

            if (btn.BackgroundImage != null) return; //Tranh viec mot button co roi ma van danh lai thi se doi thanh O;

            Marking(btn);
            MarkOrNot = true;
            ChangeTimeCounter();

            //Hàm kiểm tra rằng cho chơi đã kết thúc hay chưa
            if (IsEndGame(btn))
            {
                EndGame(); //Nếu end game rồi thì chạy hàm endgame
            }
        }
        private void Marking(Button btn)
        {
            btn.BackgroundImage = Player[CurrentPlayer].Mark;
        }

        //Phải cho QuanLyBanCo nhận tham số FormMain để có access tới các control trong đó
        //Public các control cần truy cập
        public void ChangeTimeCounter()
        {
            if (currentPlayer == 0)
            {
                MarkOrNot = false;
                FormMain.timer_Player1.Stop();
                timeG.Time1 = Constant.timePlayer1;
                FormMain.label_timePlayer1.Text = timeG.Time1.ToString();

                currentPlayer = 1;

                FormMain.timer_Player2.Start();
            }
            else if (currentPlayer == 1)
            {
                MarkOrNot = false;
                FormMain.timer_Player2.Stop();
                timeG.Time2 = Constant.timePlayer2;
                FormMain.label_timePlayer2.Text = timeG.Time2.ToString();

                currentPlayer = 0;

                FormMain.timer_Player1.Start();
            }
        }

        public void HamDanhRandom()
        {
            int VitriHang = DanhDauRandom.Next(0, 15);
            int VitriCot = DanhDauRandom.Next(0, 16);

            if(Matrix[VitriHang][VitriCot].BackgroundImage == null)
            {
                Matrix[VitriHang][VitriCot].BackgroundImage = player[currentPlayer].Mark;
                if (IsEndGame(Matrix[VitriHang][VitriCot]))
                {
                    EndGame();
                }
                return;
            }
            else
            {
                HamDanhRandom();
            }

        }

        public void EndGame()
        {
            if(currentPlayer == 0)
            {
                MessageBox.Show(Player[1].Name + " win!");
            }
            else
            {
                MessageBox.Show(Player[0].Name + " win!");
            }
        }

        public bool IsEndGame(Button btn)
        {
            if (IsEndGameHangNgang(btn) || IsEndGameHangDoc(btn) || IsEndGameDuongCheoChinh(btn) || IsEndGameDuongCheoPhu(btn))
                return true;
            return false;
        }

        //Hàm dùng để lấy tọa độ của button
        public Point GetChessPoint(Button btn)
        {
            int HangNgang = Convert.ToInt32(btn.Tag); //Hàng ngang của nút được lấy ra từ tag của nó được khởi tạo trong hàm VeBanCo()
            int HangDoc = Matrix[HangNgang].IndexOf(btn); //Hàng dọc của nút được lấy ra từ idex của list button nằm ở hàng ngang

            Point ToaDoNut = new Point(HangDoc,HangNgang); //X theo hàng dọc, Y theo hàng ngang
            return ToaDoNut;
        }
        //-------------------------------------------
        //Dưới đây là 4 trường hợp nếu xảy ra thì game kết thúc: 5 hàng ngang, dọc, đường chéo chính, đường chéo phụ
        public bool IsEndGameHangNgang(Button btn)
        {
            Point point = GetChessPoint(btn); //Lấy tọa độ của nút


            int countLeft = 0;
            //Đếm hình trùng qua trái
            //từ tag của button đếm qua trái, đến i = 0 có nghĩa là đếm tới phần tử đầu của list button
            for (int i = point.X; i >= 0; i--) 
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            //Đếm hình trùng qua phải
            //từ tag của button + 1 đếm qua qua phải đến hết chiều rộng của bàn cờ
            //tag cộng 1 là do bên trên thuật toán chạy qua trái đã đếm vị trí tag của button
            for (int i = point.X + 1; i < Constant.ChieuRongBanCo; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            if (countLeft + countRight == 5)
                return true;
            else
                return false;
        }

        public bool IsEndGameHangDoc(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            // Đếm hình trùng lên trên
            // Đếm đến phần tử thứ 0 của matrix tức là đếm hết lên trên bàn cờ (Phần tử thứ 0 của matrix là hàng button đầu tiên)
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            //Đếm hình trùng xuống dưới
            //Đếm từ phần tử phía dưới button 1 đơn vị do tag button đã được đếm ở phần đếm lên trên
            for (int i = point.Y + 1; i < Constant.ChieuCaoBanCo; i++)
            {
                if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            if (countTop + countBottom == 5)
                return true;
            else return false;
        }

        public bool IsEndGameDuongCheoChinh(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constant.ChieuRongBanCo - point.X; i++)
            {
                if (point.Y + i >= Constant.ChieuCaoBanCo || point.X + i >= Constant.ChieuRongBanCo)
                    break;

                if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }

        public bool IsEndGameDuongCheoPhu(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X + i > Constant.ChieuRongBanCo || point.Y - i < 0)
                    break;

                if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constant.ChieuRongBanCo - point.X; i++)
            {
                if (point.Y + i >= Constant.ChieuCaoBanCo || point.X - i < 0)
                    break;

                if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == 5;
        }
        //--------------------------------------------
        #endregion
    }
}
