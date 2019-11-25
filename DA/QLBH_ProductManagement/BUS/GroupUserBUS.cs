using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    
    public class GroupUserBUS
    {
        GroupUserDAO grUserDAO = new GroupUserDAO();
        public List<GroupUser> getGroupUser()
        {
            return grUserDAO.getGroupUser();
        }

        public List<GroupUser> getGroupUserFromName(string Rule_name)
        {
            
            List<GroupUser> listGR = grUserDAO.getGroupUserFromName(Rule_name);
            return listGR;
        }
    }


   
}
