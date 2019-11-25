using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class AreaDTO
    {
        private string MaKV;
        private string TenKV;
        private string GhiChu;
        private bool Active;
        public string iMaKV { get => MaKV; set => MaKV = value; }
        public string iTenKV { get => TenKV; set => TenKV = value; }
        public string iGhiChu { get => GhiChu; set => GhiChu = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
