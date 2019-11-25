using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class OBFormDAO
    {
        public List<OBForm> getListOBForm(string form_ID) // hàm này lấy ra các đối tuongj của Form
        {
            List<OBForm> listOBForm = new List<OBForm>();
            string sql = string.Format("Select [Object_ID], [OBForm_Name] from [SYS_Form_OBJECT] where [Form_ID] = '{0}' ", form_ID);
           
            DataTable data = ConnectionDB.getData(sql);
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var obForm = new OBForm();
                obForm.Object_ID = data.Rows[i]["Object_ID"].ToString();
                obForm.OBForm_Name = data.Rows[i]["OBForm_Name"].ToString();
                listOBForm.Add(obForm);
            }
            return listOBForm;
        }
    }
}
