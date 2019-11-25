using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH_ProductManagement.DTO
{
    public class RuleForm
    {
        public int ID { get; set; }
        public int GR_ID { get; set; }
        public int OBJECT_CHILD { get; set; }

        public bool AllowAdd { get; set; }
        public bool AllowDelete { get; set; }
        public bool AllowEdit { get; set; }
        public bool AllowAccess { get; set; }
        public bool AllowPrint { get; set; }
        public bool AllowExport { get; set; }
        public bool AllowImport { get; set; }
    }
}
