using System;
using System.Collections.Generic;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.GUI
{
    public partial class frmSystemLog : DevExpress.XtraEditors.XtraForm
    {
        List<SystemLogDTO> lstDiary;
        public frmSystemLog(List<SystemLogDTO> lstnk)
        {
            InitializeComponent();
            lstDiary = lstnk;
            Load += UcSystemLog;
        }
        private void UcSystemLog(object sender, EventArgs e)
        {
            FillSystemLog(lstDiary);
        }
        private void FillSystemLog(List<SystemLogDTO> lstDiary)
        {
            foreach (SystemLogDTO c in lstDiary)
            {
                string[] row = new string[] { c.NguoiDung, c.MayTinh, c.ThoiGian.ToString(), c.ChucNang, c.HanhDong };
                grcSystemLog.DataSource = row;
            }
        }
    }
}