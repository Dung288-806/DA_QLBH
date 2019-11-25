using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class KhuVucDAO
    {
        public List<KhuVuc> getKhuVuc()
        {
            string sql = "SELECT * FROM KHUVUC";
            DataTable data = ConnectionDB.getData(sql);
            List<KhuVuc> listCustomer = new List<KhuVuc>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var khuvuc = new KhuVuc();
                khuvuc.MaKV = data.Rows[i]["MaKV"].ToString();
                khuvuc.TenKV = data.Rows[i]["TenKV"].ToString();
                listCustomer.Add(khuvuc);
            }
            return listCustomer;
        }
    }
}
