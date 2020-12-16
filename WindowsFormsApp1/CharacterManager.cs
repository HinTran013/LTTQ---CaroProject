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
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Media;
using System.Resources;
using WindowsFormsApp1.Properties;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    class CharacterManager
    {
        private List<List<Button>> Matrix;
        Bitmap[] BackGroundImages;
        Guna2Panel BanChon;
        Guna2TextBox Name;

        public CharacterManager(Guna2TextBox name, Guna2Panel banchon)
        {
            BanChon = banchon;
            Name = name;


            BackGroundImages = new Bitmap[21];
            BackGroundImages[0] = Resources.role1;
            BackGroundImages[1] = Resources.role2;
            BackGroundImages[2] = Resources.role3;
            BackGroundImages[3] = Resources.role4;
            BackGroundImages[4] = Resources.role5;
            BackGroundImages[5] = Resources.role6;
            BackGroundImages[6] = Resources.role7;
            BackGroundImages[7] = Resources.role8;
            BackGroundImages[8] = Resources.role9;
            BackGroundImages[9] = Resources.role10;
            BackGroundImages[10] = Resources.role11;
            BackGroundImages[11] = Resources.role12;
            BackGroundImages[12] = Resources.role13;
            BackGroundImages[13] = Resources.role14;
            BackGroundImages[14] = Resources.role15;
            BackGroundImages[15] = Resources.role16;
            BackGroundImages[16] = Resources.role17;
            BackGroundImages[17] = Resources.role18;
            BackGroundImages[18] = Resources.role19;
            BackGroundImages[19] = Resources.role20;
            BackGroundImages[20] = Resources.role21;
        }

        public void VeBanChon()
        {
            
            //Khởi tạo đối tượng matrix
            Matrix = new List<List<Button>>();

            //Button truoc cua moi button khi tao
            Button PreButton = new Button() { Width = 0, Location = new Point(0, 0) };

            int k = 0;

            //Vong lap de tao ban co
            for (int i = 0; i < Constant.ChieuCaoBanChon; i++)
            {
                Matrix.Add(new List<Button>());


                for (int j = 0; j < Constant.ChieuRongBanChon; j++)
                {
                    Button btn = new Button();

                    btn.Width = Constant.BanChonEdge;
                    btn.Height = Constant.BanChonEdge;
                    btn.Location = new Point(PreButton.Location.X + PreButton.Width, PreButton.Location.Y);
                    //tag này cho biết rằng button đang được lưu ở hàng thứ i
                    btn.Tag = i.ToString();
                    btn.BackColor = System.Drawing.Color.FromArgb(235, 235, 224);
                    //kich thuoc cua anh qua lon' nen phai chinh kich co cua anh cho vua` voi button
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                   
                    if(i == 0)
                        btn.BackgroundImage = BackGroundImages[j];                    
                    else if(i == 1)
                        btn.BackgroundImage = BackGroundImages[j + 5];
                    else if (i == 2)
                        btn.BackgroundImage = BackGroundImages[j + 10];
                    else if(i == 3)
                        btn.BackgroundImage = BackGroundImages[j + 15];

                    //Tao event khi nhan' vao button
                    btn.Click += Btn_Click;

                    //thêm các button vào panel
                    BanChon.Controls.Add(btn);

                    //thêm button vào list thứ i của matrix
                    Matrix[i].Add(btn);

                    //Gan button moi tao lam button truoc cua button chuan bi tao
                    PreButton = btn;
                }

                //Sau khi tao xong 1 hang trong ban co, thi set X cua pre button ve 0
                //Y cua prebutton duoc day xuong 1 doan = chieu rong cua 1 o
                PreButton.Location = new Point(0, PreButton.Location.Y + Constant.BanChonEdge);
                PreButton.Width = 0;
                PreButton.Height = 0;
            }
            this.BanChon.Show();
        }

        private void Btn_Click(object sender, EventArgs e)
        {

        }
    }
}
