using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class EmployeesDTO
    {
        private string MaNV;
        private string TenNV;
        private string DiaChi;
        private string DienThoai;
        private string DiDong;
        private string Email;
        private bool Active;

        public string iMaNV { get => MaNV; set => MaNV = value; }
        public string iTenNV { get => TenNV; set => TenNV = value; }
        public string iDiaChi { get => DiaChi; set => DiaChi = value; }
        public string iDienThoai { get => DienThoai; set => DienThoai = value; }
        public string iDiDong { get => DiDong; set => DiDong = value; }
        public string iEmail { get => Email; set => Email = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
