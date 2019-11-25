using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class RuleFormDAO
    {
        public List<RuleForm> getRuleFormChild(string obChildID)
        {
            string sql = string.Format("Select [AllowAdd], [AllowDelete], [AllowEdit], [AllowAccess], [AllowPrint], [AllowExport], [AllowImport] From [SYS_RULE_FORM] where [OBJECT_CHILD_ID] = '{0}' ", obChildID);
            List<RuleForm> listRule = new List<RuleForm>();

            DataTable data = ConnectionDB.getData(sql);
            
            for (int i = 0; i < data.Rows.Count; i++)
            {
                RuleForm ruleForm = new RuleForm();
                ruleForm.AllowAccess = bool.Parse(data.Rows[i]["AllowAccess"].ToString());
                ruleForm.AllowAdd = bool.Parse(data.Rows[i]["AllowAdd"].ToString());
                ruleForm.AllowDelete = bool.Parse(data.Rows[i]["AllowDelete"].ToString());
                ruleForm.AllowEdit = bool.Parse(data.Rows[i]["AllowEdit"].ToString());
                ruleForm.AllowPrint = bool.Parse(data.Rows[i]["AllowPrint"].ToString());
                ruleForm.AllowExport = bool.Parse(data.Rows[i]["AllowExport"].ToString());
                ruleForm.AllowImport = bool.Parse(data.Rows[i]["AllowImport"].ToString());

                listRule.Add(ruleForm);

            }
            return listRule;
        }
    }
}
