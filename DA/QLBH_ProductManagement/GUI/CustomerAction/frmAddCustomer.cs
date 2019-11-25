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
using QLBH_ProductManagement.GUI.AreaAction;

namespace QLBH_ProductManagement.GUI.CustomerAction
{
    public partial class frmAddCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }
        AreaBUS areaBUS = new AreaBUS();
        private void frmAddCustomer_Load(object sender, EventArgs e)
        {
            DataTable listArea = new DataTable();
            listArea = areaBUS.getAreaDataTable();
            cmKhuVuc.DataSource = listArea;
            cmKhuVuc.DisplayMember = "TenKV";
            cmKhuVuc.ValueMember = "MaKV";

        }

        private void btnAddKV_Click(object sender, EventArgs e)
        {
            var frmadd = new frmAddArea();
            frmadd.ShowDialog();
        }

        CustomerBUS cusBUS = new CustomerBUS();
        private void btnSave_Click(object sender, EventArgs e)
        {
            CustomerDTO cusDTO = new CustomerDTO();
            cusDTO.MaKH = txtMa.Text;
            cusDTO.TenKH = txtTenKH.Text;
            cusDTO.NguoiLienHe = txtTenKH.Text;
            cusDTO.MaSoThue = txtMaThue.Text;
            cusDTO.SoTK = txtTK.Text;
            cusDTO.TenNganHang = txtNH.Text;
            cusDTO.Website = txtWeb.Text;
            cusDTO.MaKV = cmKhuVuc.SelectedValue.ToString();
            cusDTO.Fax = txtFax.Text;
            cusDTO.Email = txtEmail.Text;
            cusDTO.DienThoai = txtDT.Text;
            cusDTO.DiDong = txtMobile.Text;
            cusDTO.DiaChi = txtDiaChi.Text;
            cusDTO.Active = bool.Parse(checkQL.Checked.ToString());

            int check = cusBUS.InsertKhachHang(cusDTO);
            if (check == 1)
            {
                MessageBox.Show("Insert thành công");
            }
            else
                MessageBox.Show("Insert thất bại");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}