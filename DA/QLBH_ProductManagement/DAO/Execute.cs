using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    public class Execute
    {
        public static int InsertUpdateDelete(string sql)
        {
            ConnectionDB p = new ConnectionDB();

            p.OpenConnection();

            int nRow = 0;
            nRow = p.ExecuteNonQuery(CommandType.Text, sql);

            p.CloseConnection();

            return nRow;
        }
    }
}
