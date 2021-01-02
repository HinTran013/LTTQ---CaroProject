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
    public partial class FormRule : Form
    {
        GameSound gameSound = new GameSound();

        public FormRule()
        {
            InitializeComponent();
            
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            gameSound.StopMenuSound();
            gameSound.PlayMenuSound();
            this.Hide();
        }

        private void FormRule_Load(object sender, EventArgs e)
        {
            gameSound.PlayGameSound();
        }

        private void Sound_Button_Click(object sender, EventArgs e)
        {
            gameSound.StopGamePlaySound();

            Sound_Button.Visible = false;
            
            

            Mute_Button.Visible = true;
        }

        private void Mute_Button_Click(object sender, EventArgs e)
        {
            gameSound.PlayGameSound();

            Mute_Button.Visible = false;
            

            Sound_Button.Visible = true;
        }
    }
}
