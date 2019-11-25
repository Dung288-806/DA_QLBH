using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class GoodBUS
    {
        GoodDAO gDAO = new GoodDAO();
        public List<GoodDTO> getListGoodFromIDGroup(string maNhom)
        {
            return gDAO.getListGoodFromIDGroup(maNhom);
        }
    }
}
