using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class NhomHangDAO
    {
        
        public int DeleteListFromMa(string maNhomHang)
        {
            string sql = string.Format("Delete from [NHOMHANG] where MaNhom = '{0}'", maNhomHang);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<NhomHang> getListNhomHang()
        {
            List<NhomHang> listNhomHang = new List<NhomHang>();
            string sql = "SELECT * FROM [NHOMHANG]";
            DataTable data = ConnectionDB.getData(sql);

            foreach(DataRow row in data.Rows)
            {
                NhomHang nh = new NhomHang();
                nh.maNhomHang = row["MaNhom"].ToString();
                nh.tenNhomHang = row["TenNhom"].ToString();
                nh.ghiChu = row["GhiChu"].ToString();
                nh.kichHoat = bool.Parse(row["Active"].ToString());
                listNhomHang.Add(nh);
            }
            return listNhomHang;         
        }
    }
}
