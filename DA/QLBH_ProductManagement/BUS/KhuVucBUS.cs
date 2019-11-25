using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.BUS
{
    public class KhuVucBUS
    {
        KhuVucDAO kvDAO = new KhuVucDAO();
        public List<KhuVuc> getKhuVuc()
        {
            return kvDAO.getKhuVuc();
        }
    }
}
