using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class OBFormBUS
    {
        OBFormDAO obFrom = new OBFormDAO();
        public List<OBForm> getListOBForm(string form_ID) // hàm này lấy ra các đối tuongj của Form
        {
            return obFrom.getListOBForm(form_ID);
            
        }
    }
}
