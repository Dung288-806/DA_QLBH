using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLBH_ProductManagement.GUI.CustomerAction
{
    public partial class frmUpdateCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void textEdit2_PathChanged(object sender, BreadCrumbPathChangedEventArgs e)
        {
            MessageBox.Show("Hello");
        }

      
    }
}