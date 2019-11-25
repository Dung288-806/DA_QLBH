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
    public partial class frmWarehouseTransfer : DevExpress.XtraEditors.XtraForm
    {
        public frmWarehouseTransfer()
        {
            InitializeComponent();
        }

        private void nbiPhieuChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucWarehouseTransferPhieuChuyenKho uc = new ucWarehouseTransferPhieuChuyenKho();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }
    }
}