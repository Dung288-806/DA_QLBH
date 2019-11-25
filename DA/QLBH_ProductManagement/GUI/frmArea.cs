using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.GUI.AreaAction;
using DevExpress.XtraGrid;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmArea : DevExpress.XtraEditors.XtraForm
    {
        public frmArea()
        {
            InitializeComponent();
        }
        AreaBUS areaBUS = new AreaBUS();

        public void loadArea()
        {
            List<AreaDTO> list = areaBUS.getArea();
            grcArea.DataSource = list;
        }

        private void frmArea_Load(object sender, EventArgs e)
        {

            loadArea();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            

            
            var addKhuVuc = new frmAddArea();
            addKhuVuc.ShowDialog();
            loadArea();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcArea.FocusedView as GridView;  // ép Gridcontrol về GridView

            var maKV = gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKV"); // lấy dữ liêuj

            int check = areaBUS.DeleteArea((string)maKV);
            if(check == 1)
            {
                MessageBox.Show("Xóa thành công");
                loadArea();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void barUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GridView gridView = grcArea.FocusedView as GridView;  // ép Gridcontrol về GridView
            AreaDTO area = new AreaDTO();
            area.iMaKV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iMaKV"); // lấy dữ liêuj
            area.iTenKV = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iTenKV");
            area.iGhiChu = (string)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iGhiChu");
            area.iActive = (bool)gridView.GetRowCellValue(gridView.FocusedRowHandle, "iActive");
            var frmUpdate = new UpdateArea(area);
            frmUpdate.ShowDialog();
            loadArea();
        }

        private void barReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            loadArea();
        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}