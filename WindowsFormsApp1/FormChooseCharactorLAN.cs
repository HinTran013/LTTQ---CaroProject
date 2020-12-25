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
    public partial class FormChooseCharactorLAN : Form
    {
        CharacterManager banchon;
        public static string plName;
        public static Image plPic;

        public FormChooseCharactorLAN()
        {
            InitializeComponent();

            banchon = new CharacterManager(Name_TextBox, BanChon_Panel);
            banchon.VeBanChon();
        }

        private void OK_Button_Click(object sender, EventArgs e)
        {
            plName = Name_TextBox.Text;

            try
            {
                plPic = banchon.SelectedBtn.BackgroundImage;
            }
            catch
            {
                plPic = Properties.Resources.role1;
            }
            this.Close();
        }

        private void OK_Button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                OK_Button_Click(new Button(), new EventArgs());
        }
    }
}
