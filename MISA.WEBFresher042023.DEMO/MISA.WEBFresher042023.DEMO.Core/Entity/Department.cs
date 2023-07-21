using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WEBFresher042023.DEMO.Core.Entity
{
    public class Department : BaseEntity
    {
        public Guid DepartmentId { get; set; }
        public string DepartmentName { get; set; }
    }
}
