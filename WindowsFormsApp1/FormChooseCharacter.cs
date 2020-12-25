using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;
using WindowsFormsApp1.Properties;
namespace WindowsFormsApp1
{
    public partial class FormChooseCharacter : Form
    {
        CharacterManager banchon;
        public static string plName;
        public static Image plPic;
        public FormChooseCharacter()
        {
            InitializeComponent();

            banchon = new CharacterManager(Name_TextBox, BanChon_Panel);
            banchon.VeBanChon();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            if (Name_TextBox.Text == "" || banchon.SelectedBtn == null)
            {
                MessageBox.Show("Hãy nhập tên và chọn hình.");
            }
            else
            {
                plName = Name_TextBox.Text;
                plPic = banchon.SelectedBtn.BackgroundImage;
                this.Close();
            }
        }

        private void Name_TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Name_TextBox.Text == "" || banchon.SelectedBtn == null)
                {
                    MessageBox.Show("Hãy nhập tên và chọn hình.");
                }
                else
                {
                    plName = Name_TextBox.Text;
                    plPic = banchon.SelectedBtn.BackgroundImage;
                    this.Close();
                }
            }
        }
    }
}
