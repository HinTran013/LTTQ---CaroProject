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

namespace WindowsFormsApp1
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
      
        private void Playvshuman(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\btn_click_sound.wav";
            sp.Play();

            this.Hide();
            FormPVP f1 = new FormPVP();
            f1.ShowDialog();
            
            this.Show();
        }
        private void Rules(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\btn_click_sound.wav";
            sp.Play();

            this.Hide();
            FormRule f3 = new FormRule();
            f3.ShowDialog();
            this.Show();
        }

        private void PVC(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\btn_click_sound.wav";
            sp.Play();

            this.Hide();
            FormPVC f4 = new FormPVC();
            f4.ShowDialog();
            this.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @".\Intro_Screen.wav";
            sp.PlayLooping();
        }
    }
}
