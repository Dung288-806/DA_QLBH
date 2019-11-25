using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class GroupOfGoodsDTO
    {
        private string MaNhom;
        private string TenNhom;
        private string GhiChu;
        private bool Active;
        public string iMaNhom { get => MaNhom; set => MaNhom = value; }
        public string iTenNhom { get => TenNhom; set => TenNhom = value; }
        public string iGhiChu { get => GhiChu; set => GhiChu = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
