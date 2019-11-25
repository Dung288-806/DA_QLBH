using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class UnitDTO
    {
        private string MaDVT;
        private string Ten;
        private string GhiChu;
        private bool Active;
        public string iMaDVT { get => MaDVT; set => MaDVT = value; }
        public string iTen { get => Ten; set => Ten = value; }
        public string iGhiChu { get => GhiChu; set => GhiChu = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
