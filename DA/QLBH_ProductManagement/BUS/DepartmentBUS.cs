using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.BUS
{
    public class DepartmentBUS
    {
        DepartmentDAO departmentDAO = new DepartmentDAO();
        public List<DepartmentDTO> getDepartment()
        {
            return departmentDAO.getDepartment();
        }
    }
}
