using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DTO;


namespace QLBH_ProductManagement.DAO
{
    public class DepartmentDAO
    {
        public List<DepartmentDTO> getDepartment()
        {
            string sql = "SELECT * FROM BOPHAN";
            DataTable data = ConnectionDB.getData(sql);
            List<DepartmentDTO> list = new List<DepartmentDTO>();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                DepartmentDTO department = new DepartmentDTO();
                department.iMaBP = data.Rows[i]["MaBP"].ToString();
                department.iTenBP = data.Rows[i]["TenBP"].ToString();
                department.iGhiChu = data.Rows[i]["GhiChu"].ToString();
                department.iActive = bool.Parse(data.Rows[i]["Active"].ToString());
                list.Add(department);
            }
            return list;
        }
    }
}
