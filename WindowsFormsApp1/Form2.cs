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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
      
        private void Playvshuman(object sender, EventArgs e)
        {
            //Link form
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Show();
        }
        private void Rules(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Show();
        }
    }
}
