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
    public class UserDAO
    {
        public int getUserLogin(string userName, string pass)
        {
            string sql = String.Format("SELECT 1 FROM [SYS_USER] where UserName = '{0}' and Password = '{1}'", "admin", "01");
            int check = ConnectionDB.ExcuteQuery(sql);
            return check;
        }

        public List<UserDTO> GetUserFromGroup(string groupID)
        {
            string sql = string.Format("Select [USER_ID] ,UserName, Description, active from  SYS_USER where [GR_ID] = N'{0}'", groupID);
            DataTable data = ConnectionDB.getData(sql);
            List<UserDTO> listUser = new List<UserDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                UserDTO user = new UserDTO();
                user.GroupID = groupID;
                //user.UserID = data.Rows[i]["UserID"].ToString();
                user.NameUser = data.Rows[i]["UserName"].ToString();
                user.Description = data.Rows[i]["Description"].ToString();
                
                user.Check = bool.Parse(data.Rows[i]["Active"].ToString());
                
                listUser.Add(user);
            }
            return listUser;
        }

        public List<UserGroupDTO> GetUserGroup(string groupID, string vaiTro)
        {
            string sql = string.Format("Select UserName, Description, active from  SYS_USER where [GR_ID] = N'{0}'", groupID);

            DataTable data = ConnectionDB.getData(sql);
            List<UserGroupDTO> listUser = new List<UserGroupDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                UserGroupDTO user = new UserGroupDTO();            
                user.userName = data.Rows[i]["UserName"].ToString();
                user.dienGia = data.Rows[i]["Description"].ToString();
                user.vaiTro = vaiTro;
                user.kichHoat = bool.Parse(data.Rows[i]["Active"].ToString());
                user.groupID = groupID;
                listUser.Add(user);
            }
            return listUser;
        }
        public string GetPassword(string username)
        {
            string sql = "sp_GetPassword";

            ConnectionDB p = new ConnectionDB();
            p.OpenConnection();

            SqlParameter kq = new SqlParameter("@pass", SqlDbType.VarChar, 20);
            kq.Direction = ParameterDirection.Output;

            p.ExecuteNonQuery(CommandType.StoredProcedure, sql,
                new SqlParameter { ParameterName = "@username", Value = username }, kq);

            string pass = kq.Value.ToString();

            return pass;
        }
        public int CapNhatMatKhau(string username, string newPass)
        {
            string sql = string.Format("update NGUOIDUNG set Password = '{0}' where TenDangNhap = '{1}'",
                newPass, username);

            return Execute.InsertUpdateDelete(sql);
        }

    }
}
