using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DAO
{
    

    public class ConnectionDB
    {
        // Link Của Dũng


        
        static string path = "Data Source=DESKTOP-EKT2OFS;Initial Catalog=PM_QLBH01;Integrated Security=True";
        static SqlConnection con = new SqlConnection(path);

        //static string path = "Data Source=DESKTOP-EKT2OFS;Initial Catalog=PM_QLBH01;Integrated Security=True";
        //static SqlConnection con = new SqlConnection(path);


        // Link Của Diễm 

        //static SqlConnection con = new SqlConnection("Data Source=DIEMKIRI\\MYDIEM;Initial Catalog=PM_QLBH01;Integrated Security=True");

        // Link Của Thi

        //static SqlConnection con = new SqlConnection(@"Data Source=ANHTHI\SQLSEVER;Initial Catalog=DBQLBHSTUPID09;Integrated Security=True");

        SqlConnection Connection { get; set; }
        public void OpenConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public static DataTable getData(string sql)
        {
            DataTable data = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(data);
            return data;
        }

        public static int ExcuteQuery(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            int check = (int)com.ExecuteScalar();
            con.Close();
            return check;
        }

        public static int ExcuteNonQuery(string sql)
        {
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            int check = (int)com.ExecuteNonQuery();
            con.Close();
            return check;
        }

        // Insert, Update, Delete
        // Dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql, params SqlParameter[] parameters)
        {
            try
            {
                SqlCommand com = new SqlCommand(strSql, con);
                com.CommandText = strSql;
                com.CommandType = cmdType;
                if (parameters != null && parameters.Length > 0)
                {
                    com.Parameters.AddRange(parameters);
                }
                int nRow = com.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        // Insert, Update, Delete
        // Không dùng tham số
        public int ExecuteNonQuery(CommandType cmdType, string strSql)
        {
            try
            {
                SqlCommand command = Connection.CreateCommand();
                command.CommandText = strSql;
                command.CommandType = cmdType;

                int nRow = command.ExecuteNonQuery();
                return nRow;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

    }
}
