using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.BUS
{
    public class ChildFormBUS
    {
        FormChildDAO childForm = new FormChildDAO();
        public List<FormChild> getListOBChild(string OB_ID) // hàm này lấy ra các đối tuongj của Form
        {
            return childForm.getListOBChild(OB_ID);
        }
    }

}
