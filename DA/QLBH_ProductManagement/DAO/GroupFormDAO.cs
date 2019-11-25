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
    public class GroupFormDAO
    {
        public List<GroupForm> getGroupForm()
        {
            DataTable data = ConnectionDB.getData("Select[Form_ID], [Form_Name]  from[SYS_FORM]");
            List<GroupForm> list = new List<GroupForm>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                string form_id = data.Rows[i]["Form_ID"].ToString();
                string form_name = data.Rows[i]["Form_Name"].ToString();
                var groupForm = new GroupForm();
                groupForm.formID = form_id;
                groupForm.formName = form_name;
                list.Add(groupForm);  // có được danh sách gồm các nhóm và ID nhóm Form
            }
            return list;
        }
    }
}
