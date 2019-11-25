using System;
using QLBH_ProductManagement.BUS;
using System.Windows.Forms;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.GUI.AreaAction
{
    public partial class frmAddArea : DevExpress.XtraEditors.XtraForm
    {
        public frmAddArea()
        {
            InitializeComponent();
        }
       

        AreaBUS arBus = new AreaBUS();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string maKV = txtMaKV.Text;
            string tenKV = txtTenKV.Text;
            string ghiChu = txtGhiChu.Text;
            bool active = bool.Parse(checkAc.Checked.ToString());

           

            if(tenKV == "")
            {
                MessageBox.Show("Trường Name không được để trống");
                txtTenKV.Focus();
                
            }
            else
            {
                int check = arBus.InsertArea(maKV, tenKV, ghiChu, active);
                if (check == 1)
                {
                    MessageBox.Show("INSERT thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("INSERT thất bại");
                }
            }
           

            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddArea_Load(object sender, EventArgs e)
        {
            // KV00000 5
            string maLast = arBus.getLastMaKV();

            string maKV1 = maLast.Substring(0, maLast.Length - 3);
            string maKV2 = maLast.Substring(maLast.Length-3);
 

            int indexLast = int.Parse(maKV2);
            indexLast++;
            txtMaKV.Text = maKV1 + "" + indexLast;
            //txtMaKV.Text = maKVLast;
        }
    }
}