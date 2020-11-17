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
    public partial class Form1 : Form
    {
        #region Properties
        QuanLyBanCo BanCo;
        #endregion
        public Form1()
        {
            InitializeComponent();

            BanCo = new QuanLyBanCo(BanCo_pnl,null);
            //...
            //BanCo.hide

            BanCo.VeBanCo();   
        }
    }
}
