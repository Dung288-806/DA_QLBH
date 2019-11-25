using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class DepartmentDTO
    {
        private string MaBP;
        private string TenBP;
        private string GhiChu;
        private bool Active;
        public string iMaBP { get => MaBP; set => MaBP = value; }
        public string iTenBP { get => TenBP; set => TenBP = value; }
        public string iGhiChu { get => GhiChu; set => GhiChu = value; }
        public bool iActive { get => Active; set => Active = value; }
    }
}
