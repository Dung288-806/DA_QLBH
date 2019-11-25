using QLBH_ProductManagement.BUS;
using QLBH_ProductManagement.DTO;
using System;
using System.Windows.Forms;

namespace QLBH_ProductManagement.GUI.AreaAction
{
    public partial class UpdateArea : DevExpress.XtraEditors.XtraForm
    {
        public UpdateArea()
        {
            InitializeComponent();
        }


        AreaDTO areaDTO = new AreaDTO();
        public UpdateArea(AreaDTO area):this()
        {
            areaDTO.iMaKV = area.iMaKV;
            areaDTO.iTenKV = area.iTenKV;
            areaDTO.iGhiChu = area.iGhiChu;
            areaDTO.iActive = area.iActive;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        AreaBUS areaBUS = new AreaBUS();
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MAKV = areaDTO.iMaKV;
            string tenKV = txtTen.Text;
            string ghiChu = txtGhiChu.Text;
            bool active = bool.Parse(checkAc.Checked.ToString());

            int check = areaBUS.UpdateArea(MAKV, tenKV, ghiChu, active);
            if(check == 1)
            {
                MessageBox.Show("Sửa chữa thành công");
            }
            else
            {
                MessageBox.Show("Sửa chữa thất bại");
            }
        }

        private void UpdateArea_Load(object sender, EventArgs e)
        {
            txtMaKV.Text = areaDTO.iMaKV;
            txtMaKV.ReadOnly = true;
            txtTen.Text = areaDTO.iTenKV;
            txtGhiChu.Text = areaDTO.iGhiChu;
            checkAc.Checked = areaDTO.iActive;
        }
    }
}