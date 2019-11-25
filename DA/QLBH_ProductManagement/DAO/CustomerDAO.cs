using QLBH_ProductManagement.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLBH_ProductManagement.DAO
{
    public class CustomerDAO
    {
        public int InsertKhachHang(CustomerDTO cusDTO)
        {
            string sql = string.Format("INSERT INTO KHACHHANG values('{0}', N'{1}', N'{2}',N'{3}', N'{4}'," +
                " N'{5}',N'{6}', N'{7}', N'{8}',N'{9}', N'{10}', N'{11}','{12}', N'{13}')", cusDTO.MaKH, cusDTO.TenKH, cusDTO.NguoiLienHe, cusDTO.DiaChi, cusDTO.DienThoai
                , cusDTO.DiDong, cusDTO.Fax, cusDTO.Email, cusDTO.Website, cusDTO.MaSoThue, cusDTO.SoTK, cusDTO.TenNganHang, cusDTO.Active, cusDTO.MaKV);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }

        public int DeleteKhachHang(string Makh)
        {
            string sql = string.Format("Delete from KHACHHANG where MaKH = '{0}'", Makh);
            int check = ConnectionDB.ExcuteNonQuery(sql);
            return check;
        }


        public List<CustomerDTO> getDataCustomer(string makv)
        {
            string sql = string.Format("SELECT * FROM [KHACHHANG] where [MaKV] = '{0}'", makv);
            DataTable data = ConnectionDB.getData(sql);
            List<CustomerDTO> listCustomer = new List<CustomerDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                var customer = new CustomerDTO();
                customer.MaKH = data.Rows[i]["MaKH"].ToString();
                customer.TenKH = data.Rows[i]["TenKH"].ToString();
                customer.DiaChi = data.Rows[i]["DiaChi"].ToString();
                customer.NguoiLienHe = data.Rows[i]["NguoiLienHe"].ToString();
                customer.DiDong = data.Rows[i]["DiDong"].ToString();
                customer.Fax = data.Rows[i]["Fax"].ToString();
                customer.Email = data.Rows[i]["Email"].ToString();
                customer.Website = data.Rows[i]["Website"].ToString();
                customer.MaSoThue = data.Rows[i]["MaSoThue"].ToString();
                customer.DienThoai = data.Rows[i]["DienThoai"].ToString();
                listCustomer.Add(customer);
            }
            return listCustomer;
        }
    }
}
