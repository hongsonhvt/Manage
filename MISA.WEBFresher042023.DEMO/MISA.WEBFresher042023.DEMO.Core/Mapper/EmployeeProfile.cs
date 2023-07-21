using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Entity;

namespace MISA.WEBFresher042023.DEMO.Core.Mapper
{
    public class EmployeeProfile : Profile
    {
        public EmployeeProfile() 
        {
            CreateMap<Employee, EmployeeDto>();
            CreateMap<EmployeeCreateDto, Employee>();
            CreateMap<EmployeeUpdateDto, Employee>();
        }
    }
}
