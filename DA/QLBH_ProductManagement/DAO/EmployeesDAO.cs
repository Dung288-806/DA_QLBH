using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;


namespace QLBH_ProductManagement.DAO
{
    public class EmployeesDAO
    {
        public List<EmployeesDTO> getEmployees()
        {
            string sql = "SELECT * FROM NHANVIEN";
            DataTable data = ConnectionDB.getData(sql);
            List<EmployeesDTO> list = new List<EmployeesDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                EmployeesDTO employees = new EmployeesDTO();
                employees.iMaNV = data.Rows[i]["MaNV"].ToString();
                employees.iTenNV = data.Rows[i]["TenNV"].ToString();
                employees.iDiaChi = data.Rows[i]["DiaChi"].ToString();
                employees.iDiDong = data.Rows[i]["DiDong"].ToString();
                employees.iDienThoai = data.Rows[i]["DienThoai"].ToString();
                employees.iEmail = data.Rows[i]["Email"].ToString();
                employees.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(employees);
            }
            return list;
        }
    }
}
