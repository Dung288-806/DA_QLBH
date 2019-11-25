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
    public class EmployeesBUS
    {
        EmployeesDAO employeesDAO = new EmployeesDAO();
        public List<EmployeesDTO> getEmployees()
        {
            return employeesDAO.getEmployees();
        }
    }
}
