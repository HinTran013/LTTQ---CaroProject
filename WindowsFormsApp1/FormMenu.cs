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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
      
        private void Playvshuman(object sender, EventArgs e)
        {
            //Link form
            this.Hide();
            FormPVP f1 = new FormPVP();
            f1.ShowDialog();
            this.Show();
        }
        private void Rules(object sender, EventArgs e)
        {
            this.Hide();
            FormRule f3 = new FormRule();
            f3.ShowDialog();
            this.Show();
        }
    }
}
