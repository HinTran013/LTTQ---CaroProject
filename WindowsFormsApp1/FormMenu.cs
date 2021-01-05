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
using System.Threading;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        GameSound gameSound;

        public FormMenu()
        {
            InitializeComponent();
            gameSound = new GameSound();

            Mute_Button.Visible = false;
        }
      
        private void Playvshuman(object sender, EventArgs e)
        {
            gameSound.StopMenuSound();
            
            this.Hide();
            FormPVP f1 = new FormPVP();

            f1.Owner = this;
            f1.ShowDialog();
            
            this.Show();
        }
        private void Rules(object sender, EventArgs e)
        {
            gameSound.StopMenuSound();
            this.Hide();
            FormRule f3 = new FormRule();
            
            f3.ShowDialog();
            this.Show();
        }

        private void PVC(object sender, EventArgs e)
        {
            gameSound.StopMenuSound();
            gameSound.PlayGameSound();
            this.Hide();
            FormPVC f4 = new FormPVC();
            f4.ShowDialog();
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            gameSound.PlayMenuSound();
            
        }

        private void Sound_Button_Click(object sender, EventArgs e)
        {
            gameSound.StopMenuSound();

            
            Sound_Button.Visible = false;
            Mute_Button.Visible = true;
        }

        private void Mute_Button_Click(object sender, EventArgs e)
        {
            gameSound.PlayMenuSound();

            Mute_Button.Visible = false;
            Sound_Button.Visible = true;
        }

        private void FormMenu_VisibleChanged(object sender, EventArgs e)
        {
            Mute_Button.Visible = false;
            Sound_Button.Visible = true;
        }
    }
}
