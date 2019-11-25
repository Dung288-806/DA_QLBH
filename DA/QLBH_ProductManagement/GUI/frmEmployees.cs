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
    public partial class frmEmployees : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        EmployeesBUS employeesBUS = new EmployeesBUS();
        private void grcEmployees_Load(object sender, EventArgs e)
        {
            List<EmployeesDTO> list = employeesBUS.getEmployees();
            grcEmployees.DataSource = list;
        }
    }
}