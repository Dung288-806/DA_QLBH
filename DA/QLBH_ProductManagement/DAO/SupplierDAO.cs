using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class SupplierDAO
    {
        public int DeleteSupplierFromNCC(string maNCC)
        {
            string sql = string.Format("Delete from NCC where MaNCC = '{0}'", maNCC);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public List<SupplierDTO> getSupplierFromNCC(string maNCC)
        {
            string sql = string.Format("SELECT * from [NCC] where [MaKV] = '{0}'", maNCC);
            DataTable data = ConnectionDB.getData(sql);
            List<SupplierDTO> listSupplier = new List<SupplierDTO>();
            foreach(DataRow row in data.Rows)
            {
                var SupplierDTO = new SupplierDTO();
                SupplierDTO.MaNCC = row["MaNCC"].ToString();
                SupplierDTO.TenNCC = row["TenNCC"].ToString();
                SupplierDTO.NguoiLienHe = row["NguoiLH"].ToString();
                SupplierDTO.ChucVu = row["ChucVu"].ToString();
                SupplierDTO.DiaChi = row["DiaChi"].ToString();
                SupplierDTO.DienThoai = row["DienThoai"].ToString();
                SupplierDTO.DiDong = row["DiDong"].ToString();
                SupplierDTO.Fax = row["Fax"].ToString();
                SupplierDTO.Active = bool.Parse(row["Active"].ToString());
                listSupplier.Add(SupplierDTO);

            }
            return listSupplier;
        }
    }
}
