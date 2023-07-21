using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Interface;
using MISA.WEBFresher042023.DEMO.Core.Enum;
using MISA.WEBFresher042023.DEMO.Core.MISAException;
using MISA.WEBFresher042023.DEMO.Core.Entity;
using MISA.WEBFresher042023.DEMO.Core.Interface.Service;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;
using AutoMapper;

namespace MISA.WEBFresher042023.DEMO.Core.Service
{
    public class EmployeeService :  BaseService<Employee, EmployeeDto, EmployeeCreateDto, EmployeeUpdateDto>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository , IMapper mapper) : base(employeeRepository, mapper)
        {
            _employeeRepository = employeeRepository;   
        }

        public async Task<bool> isDuplicatedAsync(string code)
        {
            var resuilt = await _employeeRepository.IsDuplicateAsync(code);
            return resuilt;
        }
    }
}
