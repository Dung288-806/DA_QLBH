using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList.Nodes;
using QLBH_ProductManagement.BUS;
using DevExpress.XtraTreeList;
using System.Windows.Forms;
using QLBH_ProductManagement.GUI.CustomerAction;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        KhuVucBUS khuVucBus = new KhuVucBUS();
        CustomerBUS cusBUS = new CustomerBUS();


        public void LoadKhachHang()
        {
            List<CustomerDTO> listCustomer = new List<CustomerDTO>();
            List<KhuVuc> listKhuVuc = new List<KhuVuc>();
            listKhuVuc = khuVucBus.getKhuVuc();
            for (int i = 0; i < listKhuVuc.Count; i++)
            {
                TreeListNode prarentNode = treeListKH.AppendNode(null, null);
                prarentNode.SetValue("MaKH", listKhuVuc[i].TenKV);
                listCustomer = cusBUS.getDataCustomer(listKhuVuc[i].MaKV);
                for (int j = 0; j < listCustomer.Count; j++)
                {
                    TreeListNode childnode1 = null;
                    childnode1 = treeListKH.AppendNode(null, prarentNode);
                    childnode1.SetValue("MaKH", listCustomer[j].MaKV);
                    childnode1.SetValue("MaKH", listCustomer[j].MaKH);
                    childnode1.SetValue("TenKH", listCustomer[j].TenKH);
                    childnode1.SetValue("NguoiLienHe", listCustomer[j].NguoiLienHe);
                    childnode1.SetValue("DiaChi", listCustomer[j].DiaChi);
                    childnode1.SetValue("DienThoai", listCustomer[j].DienThoai);
                    childnode1.SetValue("DiDong", listCustomer[j].DiDong);
                    childnode1.SetValue("Email", listCustomer[j].Email);
                    childnode1.SetValue("Website", listCustomer[j].Website);
                    childnode1.SetValue("Fax", listCustomer[j].Fax);
                    childnode1.SetValue("MaSoThue", listCustomer[j].MaSoThue);
                }
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nodes = treeListKH.Selection;
            foreach (TreeListNode node in nodes)
            {
                var id = node.GetValue("MaKH");
                int check = cusBUS.DeleteKhachHang((string)id);
                if (check == 1)
                {
                    MessageBox.Show("Delete thành công");
                    treeListKH.ClearNodes();
                    LoadKhachHang();
                    break;
                }
                else
                    MessageBox.Show("Delete thất bại");
            }
            
        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var addCus = new frmAddCustomer();
            addCus.ShowDialog();
            treeListKH.ClearNodes();
            LoadKhachHang();
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var updateCus = new frmUpdateCustomer();
            updateCus.ShowDialog();
        }

        private void barReset_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadKhachHang();
        }

        private void barClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}