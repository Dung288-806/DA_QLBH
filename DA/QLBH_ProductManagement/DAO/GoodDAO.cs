using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class GoodDAO
    {
        public List<GoodDTO> getListGoodFromIDGroup(string maNhom)
        {
            string sql = string.Format("Select * from [HANGHOA_DICHVU] where MaNhom = '{0}'", maNhom);

            DataTable data = ConnectionDB.getData(sql);
            List<GoodDTO> ListGood = new List<GoodDTO>();
            foreach (DataRow row in data.Rows)
            {
                GoodDTO good = new GoodDTO();
                good.MaHang = row["MaHang"].ToString();
                good.TenHang = row["TenHang"].ToString();
                good.MaDonVi = row["MaDV"].ToString();
                good.GiaMua = row["GiaMua"].ToString();
                good.GiabanLe = row["GiaBanLe"].ToString();
                good.GiaBanSi = row["GiaBanSi"].ToString();
                good.ToiThieu = row["ToiThieu"].ToString();
                good.TinhChat = row["TinhChat"].ToString();
                good.MaKho = row["MaKho"].ToString();
                good.Active = bool.Parse(row["Active"].ToString());
                ListGood.Add(good);
                
            }
            return ListGood;
        }
    }
}
