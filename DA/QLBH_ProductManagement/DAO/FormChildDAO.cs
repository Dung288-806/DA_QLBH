using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class FormChildDAO
    {
        public List<FormChild> getListOBChild(string OB_ID) // hàm này lấy ra các đối tuongj của Form
        {
            List<FormChild> listFormChild = new List<FormChild>();

            string sql = string.Format("Select OBJECT_CHILD_ID, Child_Name from [SYS_OBJECT_CHILD] where [Object_ID] = '{0}' ", OB_ID);

            DataTable data = ConnectionDB.getData(sql);

            for (int i = 0; i < data.Rows.Count; i++)
            {
                var formChild = new FormChild();
                formChild.OBJECT_CHILD_ID = data.Rows[i]["OBJECT_CHILD_ID"].ToString();
                formChild.Child_Name = data.Rows[i]["Child_Name"].ToString();
                listFormChild.Add(formChild);
            }
            return listFormChild;
        }
    }
}
