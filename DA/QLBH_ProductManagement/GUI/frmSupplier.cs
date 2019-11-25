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
using QLBH_ProductManagement.GUI.SupplierAction;
using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using DevExpress.XtraTreeList.Nodes;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSupplier : DevExpress.XtraEditors.XtraForm
    {
        public frmSupplier()
        {
            InitializeComponent();
        }
        KhuVucBUS khuVucBus = new KhuVucBUS();
        SupplierBUS supplierBUS = new SupplierBUS();
        public void loadSupplier()
        {
            // lấy khu vực
            List<KhuVuc> listKhuVuc = new List<KhuVuc>();
            listKhuVuc = khuVucBus.getKhuVuc();

            for (int i = 0; i < listKhuVuc.Count; i++)
            {
                List<SupplierDTO> listSupplier = new List<SupplierDTO>();
                listSupplier = supplierBUS.getSupplierFromNCC(listKhuVuc[i].MaKV);

                TreeListNode prarentNode = treeSupplier.AppendNode(null, null);
                prarentNode.SetValue("MaNCC", listKhuVuc[i].TenKV);

                for (int j = 0; j < listSupplier.Count; j++)
                {
                    TreeListNode childnode1 = null;
                    childnode1 = treeSupplier.AppendNode(null, prarentNode);

                    childnode1.SetValue("MaNCC", listSupplier[j].MaNCC);
                    childnode1.SetValue("TenNCC", listSupplier[j].TenNCC);
                    childnode1.SetValue("NguoiLH", listSupplier[j].NguoiLienHe);
                    childnode1.SetValue("DiaChi", listSupplier[j].DiaChi);
                    childnode1.SetValue("DienThoai", listSupplier[j].DienThoai);
                    childnode1.SetValue("DiDong", listSupplier[j].DiDong);
                    childnode1.SetValue("Fax", listSupplier[j].Fax);
                    childnode1.SetValue("ChucVu", listSupplier[j].ChucVu);
                    childnode1.SetValue("Active", listSupplier[j].Active);

                }
            }
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            loadSupplier();
        }

        private void barEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var updateSupplier = new frmUpdateSupplier();
            updateSupplier.ShowDialog();
        }

        private void barDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nodes = treeSupplier.Selection;
            foreach (TreeListNode node in nodes)
            {
                var id = node.GetValue("MaNCC");
                int check = supplierBUS.DeleteSupplierFromNCC((string)id);
                if (check == 1)
                {
                    MessageBox.Show("Delete thành công");
                    treeSupplier.ClearNodes();
                    loadSupplier();
                    break;
                }
                else
                    MessageBox.Show("Delete thất bại");
            }
        }

        private void barAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}