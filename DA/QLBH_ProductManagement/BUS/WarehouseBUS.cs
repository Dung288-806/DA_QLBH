using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;

namespace QLBH_ProductManagement.BUS
{
    
    public class WarehouseBUS
    {
        WarehouseDAO warehouseDAO = new WarehouseDAO();

        public string getNameKhoHang(string MaKho)
        {
            return warehouseDAO.getNameKhoHang(MaKho);

        }

        public List<WarehouseDTO> getWarehouse()
        {
            return warehouseDAO.getWarehouse();
        }
    }
}
