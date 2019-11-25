using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class AreaDAO
    {
        public string getLastMaKV()
        {
            string sql = "select top 1 * from KHUVUC order by MaKV DESC";
            DataTable data = ConnectionDB.getData(sql);
            string maKV = data.Rows[0]["MaKV"].ToString();
            return maKV;
        }

        public int UpdateArea(string maKV, string tenKV, string ghiChu, bool active)
        {
            string sql = string.Format("Update KhuVuc set TenKV = N'{0}', GhiChu = N'{1}', Active = '{2}' where MaKV = '{3}'", tenKV, ghiChu, active, maKV);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int DeleteArea(string maKv)
        {
            string sql = string.Format("Delete from KhuVuc where MaKV = '{0}'", maKv);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int InsertArea(string maKV, string tenKV, string ghiChu, bool active)
        {
            string sql = string.Format("INSERT INTO KHUVUC Values(N'{0}', N'{1}', N'{2}', '{3}')", maKV, tenKV, ghiChu, active);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<AreaDTO> getArea()
        {
            string sql = "SELECT * FROM KHUVUC";
            DataTable data = ConnectionDB.getData(sql);
            List<AreaDTO> list = new List<AreaDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                AreaDTO area = new AreaDTO();
                area.iMaKV = data.Rows[i]["MaKV"].ToString();
                area.iTenKV = data.Rows[i]["TenKV"].ToString();
                area.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                area.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(area);
            }
            return list;
        }

        public DataTable getAreaDataTable()
        {
            string sql = "SELECT * FROM KHUVUC";
            DataTable data = ConnectionDB.getData(sql);
            return data;
        }
    }
}
