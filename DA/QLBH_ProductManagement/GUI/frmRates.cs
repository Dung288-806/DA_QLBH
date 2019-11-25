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
    public partial class frmRates : DevExpress.XtraEditors.XtraForm
    {
        public frmRates()
        {
            InitializeComponent();
        }
        RatesBUS ratesBUS = new RatesBUS();

        private void grcRates_Load(object sender, EventArgs e)
        {
            List<RatesDTO> list = ratesBUS.getRates();
            grcRates.DataSource = list;
        }
    }
}