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
    public partial class FormPVP : Form
    {
        #region Properties
        QuanLyBanCo BanCo;
        #endregion
        public FormPVP()
        {
            InitializeComponent();

            BanCo = new QuanLyBanCo(BanCo_pnl,null);
            //...
            //BanCo.hide

            BanCo.VeBanCo();   
        }
    }
}
