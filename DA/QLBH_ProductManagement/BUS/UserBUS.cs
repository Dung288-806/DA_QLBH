using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH_ProductManagement.BUS
{
    class UserBUS
    {
        UserDAO userDAO = new UserDAO();
        public int Login(string name, string pass)
        {
            return userDAO.getUserLogin(name, pass);
        }

        public List<UserDTO> GetUserFromGroup(string groupID)
        {
            return userDAO.GetUserFromGroup(groupID);
        }

        public List<UserGroupDTO> GetUserGroup(string groupID, string vaiTro)
        {
            return userDAO.GetUserGroup(groupID, vaiTro);
        }
        public string GetPassword(string username)
        {
            return userDAO.GetPassword(username);
        }
        public int CapNhatMatKhau(string username, string newPass)
        {
            return userDAO.CapNhatMatKhau(username, newPass);
        }
    }
}
