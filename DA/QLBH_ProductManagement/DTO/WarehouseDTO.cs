using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class WarehouseDTO
    {
        private string MaKho;
        private string TenKho;
        private string LienHe;
        private string DiaChi;
        private string DienThoai;
        private string KyHieu;
        private string GhiChu;
        private bool Active;
        public string iMaKho { get => MaKho; set => MaKho = value; }
        public string iTenKho { get => TenKho; set => TenKho = value; }
        public string iLienHe { get => LienHe; set => LienHe = value; }
        public string iDiaChi { get => DiaChi; set => DiaChi = value; }
        public string iDienThoai { get => DienThoai; set => DienThoai = value; }
        public string iKyHieu { get => KyHieu; set => KyHieu = value; }
        public string iGhiChu { get => GhiChu; set => GhiChu = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
