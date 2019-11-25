using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSell : DevExpress.XtraEditors.XtraForm
    {
        public frmSell()
        {
            InitializeComponent();
        }

        private void nbiPhieuBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucSellPhieuBanHang uc = new ucSellPhieuBanHang();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
    }
}