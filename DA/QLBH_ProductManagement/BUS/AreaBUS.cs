using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Data;

namespace QLBH_ProductManagement.BUS
{
    public class AreaBUS
    {
        AreaDAO areaDAO = new AreaDAO();

        public DataTable getAreaDataTable()
        {
            return areaDAO.getAreaDataTable();
        }

        public string getLastMaKV()
        {
            return areaDAO.getLastMaKV();
        }
        public int UpdateArea(string maKV, string tenKV, string ghiChu, bool active)
        {
            return areaDAO.UpdateArea(maKV, tenKV, ghiChu, active);
        }

        public int DeleteArea(string maKv)
        {
            return areaDAO.DeleteArea(maKv);
        }

        public int InsertArea(string maKV, string tenKV, string ghiChu, bool active)
        {
            
            return areaDAO.InsertArea(maKV, tenKV, ghiChu, active);
        }

        public List<AreaDTO> getArea()
        {
            return areaDAO.getArea();
        }
    }
}
