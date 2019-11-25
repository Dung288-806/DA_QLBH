using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class SupplierDTO
    {
           public string MaNCC {get;set;}
           public string TenNCC {get;set;}
	       public string NguoiLienHe {get;set;}
	       public string ChucVu {get;set;}
	       public string DiaChi {get;set;}
	       public string DienThoai {get;set;}
	       public string DiDong {get;set;}
	       public string Fax {get;set;}
	       public bool Active {get;set;}
	       public string MaKV  {get;set;}
    }
}
