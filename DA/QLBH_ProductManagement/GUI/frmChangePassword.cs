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
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmChangePassword : DevExpress.XtraEditors.XtraForm
    {
        //Tạo event lưu nhật ký hệ thống
        public delegate void NhatKyHeThong(SystemLogDTO diary);
        //public event NhatKyHeThong ThemNhatKyHeThong;
        public frmChangePassword(string uname)
        {
            InitializeComponent();
            Load += FrmDoiMatKhau_Load;

            username = uname;

            btnThoat.Click += BtnThoat_Click;
            btnDongY.Click += BtnDongY_Click;
        }
        //Tên chức năng hiện tại
        string TenChucNang = "Đổi Mật Khẩu";

        UserBUS user = new UserBUS();
        string username;
        private void AddNhatKy(string hanhDong)
        {
            SystemLogDTO nk = new SystemLogDTO();
            nk.NguoiDung = username;
            nk.MayTinh = System.Environment.MachineName;
            nk.ThoiGian = DateTime.Now;
            nk.ChucNang = TenChucNang;
            nk.HanhDong = hanhDong;

            //ThemNhatKyHeThong(nk);
        }
        private void FrmDoiMatKhau_Load(object sender, EventArgs e)
        {
            AddNhatKy("Truy Cập");
        }
        private void BtnDongY_Click(object sender, EventArgs e)
        {
            string pass = user.GetPassword(username);
            string oldPass = txtPassOld.Text;

            if (string.Compare(pass, oldPass) != 0)
            {
                XtraMessageBox.Show("Mật Khẩu cũ không đúng", "Sai Mật Khẩu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.Compare(txtNew.Text, txtPass_New.Text) != 0)
                {
                    XtraMessageBox.Show("Mật khẩu nhập lại không trùng khớp!", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int kq = user.CapNhatMatKhau(username, txtNew.Text);

                    if (kq >= 1)
                    {
                        AddNhatKy("Thành Công");
                        MessageBox.Show("Cập nhật Thành Công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật Thất Bại!");
                    }
                }
            }
        }   
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}