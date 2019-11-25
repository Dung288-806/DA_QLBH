using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class GroupUserDAO
    {
        public List<GroupUser> getGroupUser()
        {
            string sql = "SELECT * FROM [SYS_GroupUser]";
            DataTable data = ConnectionDB.getData(sql);
            List<GroupUser> listGroup = new List<GroupUser>();
            for(int i = 0; i < data.Rows.Count; i++)
            {
                GroupUser userGroup = new GroupUser();
                userGroup.GR_ID = data.Rows[i]["GR_ID"].ToString();
                userGroup.Group_Name = data.Rows[i]["Group_Name"].ToString();
                userGroup.Group_NameEn = data.Rows[i]["Group_NameEn"].ToString();
                userGroup.Description = data.Rows[i]["Description"].ToString();
                userGroup.Active = bool.Parse(data.Rows[i]["Active"].ToString());
                listGroup.Add(userGroup);
            }
            return listGroup;
        }

        public List<GroupUser> getGroupUserFromName(string Group_Name)
        {

            string sql = string.Format("Select GR_ID, Group_Name, Description, Active  from [SYS_GroupUser] where [Group_Name] = N'{0}'", Group_Name);
            DataTable data = ConnectionDB.getData(sql);
            List<GroupUser> listGroup = new List<GroupUser>();
            if (data.Rows.Count > 0)
            {
                GroupUser group = new GroupUser();
                group.GR_ID = data.Rows[0]["GR_ID"].ToString();
                group.Group_Name = data.Rows[0]["Group_Name"].ToString();
                group.Description = data.Rows[0]["Description"].ToString();
                group.Active = bool.Parse(data.Rows[0]["Active"].ToString());
                listGroup.Add(group);
            }
            return listGroup;
        }
    }
}
