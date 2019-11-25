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
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraVerticalGrid;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmGroupOfGoods : DevExpress.XtraEditors.XtraForm
    {
        public frmGroupOfGoods()
        {
            InitializeComponent();
        }
        NhomHangBUS nhBUS = new NhomHangBUS();
        

        public void reFeshListNhomHang()
        {
            List<NhomHang> list = nhBUS.getListNhomHang();
            listNhomHang.DataSource = list;
        }


        private void frmGroupOfGoods_Load(object sender, EventArgs e)
        {
            reFeshListNhomHang();


        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gv = listNhomHang.MainView as GridView;
            var index = gv.FocusedRowHandle;
            var cellValue = gv.GetRowCellValue(index, "maNhomHang");
            int check = nhBUS.DeleteNhomHang((string)cellValue);
            if (check == 1)
            {
                MessageBox.Show("Xóa thành công");
                reFeshListNhomHang();
            }
            else
                MessageBox.Show("Xóa thất bại");
        }
    }
}