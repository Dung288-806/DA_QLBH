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
    public partial class frmWarehouse : DevExpress.XtraEditors.XtraForm
    {
        public frmWarehouse()
        {
            InitializeComponent();
        }
        WarehouseBUS warehouseBUS = new WarehouseBUS();
        private void grcWarehouse_Load(object sender, EventArgs e)
        {
            List<WarehouseDTO> list = warehouseBUS.getWarehouse();
            grcWarehouse.DataSource = list;
        }
    }
}