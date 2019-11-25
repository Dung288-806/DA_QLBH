using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.DAO
{
    public class WarehouseDAO
    {

        public string getNameKhoHang(string MaKho)
        {
            string sql = string.Format("Select TenKho from KhoHang where MaKHo = '{0}'", MaKho);
            DataTable data = ConnectionDB.getData(sql);
            string name = data.Rows[0]["TenKho"].ToString();
            return name;
        }

        public List<WarehouseDTO> getWarehouse()
        {
            string sql = "SELECT * FROM KHOHANG";
            DataTable data = ConnectionDB.getData(sql);
            List<WarehouseDTO> list = new List<WarehouseDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                WarehouseDTO warehouse = new WarehouseDTO();
                warehouse.iMaKho = data.Rows[i]["MaKho"].ToString();
                warehouse.iTenKho = data.Rows[i]["TenKho"].ToString();
                warehouse.iLienHe = data.Rows[i]["LienHe"].ToString();
                warehouse.iDiaChi = data.Rows[i]["DiaChi"].ToString();
                warehouse.iDienThoai = data.Rows[i]["DienThoai"].ToString();
                warehouse.iKyHieu = data.Rows[i]["KyHieu"].ToString();
                warehouse.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                warehouse.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(warehouse);
            }
            return list;
        }
    }
}
