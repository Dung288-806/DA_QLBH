using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class SupplierBUS
    {
        SupplierDAO supplierDAO = new SupplierDAO();

        public int DeleteSupplierFromNCC(string maNCC)
        {
            return supplierDAO.DeleteSupplierFromNCC(maNCC);
         }

        public List<SupplierDTO> getSupplierFromNCC(string maNCC)
        {
            return supplierDAO.getSupplierFromNCC(maNCC);
        }
    }

    
}