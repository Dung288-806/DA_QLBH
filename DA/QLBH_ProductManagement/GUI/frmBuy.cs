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
    public partial class frmBuy : DevExpress.XtraEditors.XtraForm
    {
        public frmBuy()
        {
            InitializeComponent();
        }

        private void nbiPhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyPhieuNhapHang uc = new ucBuyPhieuNhapHang();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoChungTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyTheoChungTu uc = new ucBuyTheoChungTu();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiTheoHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ucBuyTheoHangHoa uc = new ucBuyTheoHangHoa();
            uc.Dock = DockStyle.Fill;
            userControl.Controls.Clear();
            userControl.Controls.Add(uc);
            userControl.Dock = DockStyle.Fill;
        }

        private void nbiHangHoa_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBuy_Goods frmBuy_Goods = new frmBuy_Goods();
            frmBuy_Goods.ShowDialog();
        }

        private void nbiKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBuy_Customer frmBuy_Customer = new frmBuy_Customer();
            frmBuy_Customer.ShowDialog();
        }

        private void nbiKhoHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            frmBuy_Warehouse frmBuy_Warehouse = new frmBuy_Warehouse();
            frmBuy_Warehouse.ShowDialog();
        }
    }
}