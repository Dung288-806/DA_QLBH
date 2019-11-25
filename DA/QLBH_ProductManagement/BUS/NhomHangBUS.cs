using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.BUS
{
    public class NhomHangBUS
    {
        NhomHangDAO nhDAO = new NhomHangDAO(); 
        public int DeleteNhomHang(string maNhom)
        {
            return nhDAO.DeleteListFromMa(maNhom);
        }

        public List<NhomHang> getListNhomHang()
        {
            return nhDAO.getListNhomHang();
        }
    }
}
