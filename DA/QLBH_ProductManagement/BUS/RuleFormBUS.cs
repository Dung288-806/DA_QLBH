using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.BUS
{
    public class RuleFormBUS
    {
        RuleFormDAO fuleForm = new RuleFormDAO();
        public List<RuleForm> getRuleFormChild(string obChildID)
        {
            return fuleForm.getRuleFormChild(obChildID);
        }
    }

}
