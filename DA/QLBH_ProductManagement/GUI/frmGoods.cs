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
using QLBH_ProductManagement.DAO;
using DevExpress.XtraTreeList.Nodes;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmGoods : DevExpress.XtraEditors.XtraForm
    {
        public frmGoods()
        {
            InitializeComponent();
        }
        GroupOfGoodsBUS grGoods = new GroupOfGoodsBUS();
        GoodBUS gBUS = new GoodBUS();
        UnitBUS unitBUS = new UnitBUS();
        WarehouseBUS wareBUS = new WarehouseBUS();
        private void frmGoods_Load(object sender, EventArgs e)
        {
            // lấy danh sách nhóm hàng
            List<GroupOfGoodsDTO> listGroup = grGoods.GetGroupOfGoods();

            for(int i = 0; i < listGroup.Count; i++)
            {
                TreeListNode prarentNode = treeListMatHang.AppendNode(null, null);
                prarentNode.SetValue("MaHang", listGroup[i].iTenNhom);

                // lấy danh sách mặt hàng theo gr

                List<GoodDTO> listGood = gBUS.getListGoodFromIDGroup(listGroup[i].iMaNhom);

                for(int j = 0; j < listGood.Count; j++)
                {
                    TreeListNode childnode1 = null;
                    childnode1 = treeListMatHang.AppendNode(null, prarentNode);

                    childnode1.SetValue("MaHang", listGood[j].MaHang);
                    childnode1.SetValue("TenHang", listGood[j].TenHang);
                    childnode1.SetValue("GiaMua", listGood[j].GiaMua);
                    childnode1.SetValue("BanLe", listGood[j].GiabanLe);
                    childnode1.SetValue("BanSi", listGood[j].GiaBanSi);
                    string nameDV = unitBUS.getNameUnit(listGood[j].MaDonVi);
                    childnode1.SetValue("DonVi", nameDV);
                    string nameKHO = wareBUS.getNameKhoHang(listGood[j].MaKho);
                    childnode1.SetValue("KhoMacDinh", nameKHO);
                    childnode1.SetValue("ToiThieu", listGood[j].ToiThieu);
                    childnode1.SetValue("TinhChat", listGood[j].TinhChat);
                    childnode1.SetValue("QuanLy", listGood[j].Active);

                }
            }



            // lấy dánh sách các mặt hàng theo nhóm

            
            // 
        }
    }
}