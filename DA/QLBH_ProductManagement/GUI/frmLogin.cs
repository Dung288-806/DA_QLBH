using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLBH_ProductManagement.BUS;

namespace QLBH_ProductManagement.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        UserBUS user_BUS = new UserBUS();
        int checkCloseFrmLogin = 0;
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string name = txtUser.Text;
            string pass = txtPass.Text;
            int check = user_BUS.Login(name, pass);
            if(check == 1)
            {
                XtraMessageBox.Show("Đăng nhập thành công");
                checkCloseFrmLogin = 1;
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("Thông tin tài khoản không chính xác");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //pictureBox.Image = Image.FromFile(@"C:\Users\Dung288\Desktop\DA_UDQL\CODE\QLBH_ProductManagement\QLBH_ProductManagement\Images\login.png");
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {  
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(checkCloseFrmLogin == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát không? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                var frmLogin = new frmLogin();
                //skin();
                frmLogin.ShowDialog();
               
            }
        }
    }
}