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
    public partial class frmUnit : DevExpress.XtraEditors.XtraForm
    {
        public frmUnit()
        {
            InitializeComponent();
        }
        UnitBUS unitBUS = new UnitBUS();
        private void grcUnit_Load(object sender, EventArgs e)
        {
            List<UnitDTO> list = unitBUS.getUnit();
            grcUnit.DataSource = list;
        }
    }
}