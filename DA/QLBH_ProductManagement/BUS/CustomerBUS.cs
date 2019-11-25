using QLBH_ProductManagement.DAO;
using QLBH_ProductManagement.DTO;
using System.Collections.Generic;

namespace QLBH_ProductManagement.BUS
{
    public class CustomerBUS
    {
        CustomerDAO customer = new CustomerDAO();

        public int InsertKhachHang(CustomerDTO cusDTO)
        {
            return customer.InsertKhachHang(cusDTO);
        }

        public int DeleteKhachHang(string maKH)
        {
            return customer.DeleteKhachHang(maKH);
        }

        public List<CustomerDTO> getDataCustomer(string makv)
        {
            return customer.getDataCustomer(makv);
        }
    }
}
