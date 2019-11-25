using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class UserDTO
    {
        private string nameUser;
        private string pass;
        private string description;
        private bool check;
        private string userID;
        private string groupID;

        public string NameUser { get => nameUser; set => nameUser = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Description { get => description; set => description = value; }
        public bool Check { get => check; set => check = value; }
        public string UserID { get => userID; set => userID = value; }
        public string GroupID { get => groupID; set => groupID = value; }
    }
}
