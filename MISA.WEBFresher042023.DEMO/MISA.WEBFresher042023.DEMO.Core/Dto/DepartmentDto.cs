using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WEBFresher042023.DEMO.Core.Dto
{
    public class DepartmentDto
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
         public DateTime? CreateDate { get; set; }
        public string? CreateBy { get; set; }
    }
}
