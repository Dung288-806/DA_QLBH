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


namespace QLBH_ProductManagement.GUI
{
    public partial class frmDepartment : DevExpress.XtraEditors.XtraForm
    {
        public frmDepartment()
        {
            InitializeComponent();
        }

        DepartmentBUS departmentBUS = new DepartmentBUS();
        private void grcDepartment_Load(object sender, EventArgs e)
        {
            List<DepartmentDTO> list = departmentBUS.getDepartment();
            grcDepartment.DataSource = list;
        }

    }
}