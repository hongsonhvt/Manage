using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Entity;

namespace MISA.WEBFresher042023.DEMO.Core.Interface.Service
{
    public interface IEmployeeService : IBaseService<EmployeeDto, EmployeeCreateDto, EmployeeUpdateDto>
    {
        Task<bool> isDuplicatedAsync(string code);
    }
}
