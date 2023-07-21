using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Entity;

namespace MISA.WEBFresher042023.DEMO.Core.Interface.Repository
{
    /// <summary>
    /// Interface Employee Repository
    /// </summary>
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        Task<int> DeleteEmployeeAsync(Guid employeeId);
        Task GetEmployeeAsync(Guid employeeId);
        Task<IEnumerable<Employee>> GetListEmployeeAsync(int page, int pageSize, string? employeeFilter);
        Task<int> InsertEmployeeAsync(EmployeeCreateDto employeeCreateDto);
        Task<bool> IsDuplicateAsync(string code);
        Task<int> UpdateEmployeeAsync(Guid employeeId, EmployeeUpdateDto employeeUpdateDto);
    }
}
