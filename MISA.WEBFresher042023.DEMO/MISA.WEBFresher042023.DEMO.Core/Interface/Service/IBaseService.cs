using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MISA.WEBFresher042023.DEMO.Core.Dto;

namespace MISA.WEBFresher042023.DEMO.Core.Interface.Service
{
    public interface IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>
    {
        Task<EmployeeDto> GetAsync(Guid id);  

        Task<List<EmployeeDto>> GetAllAsync();

        Task<EmployeeDto> InsertAsync(TEntityCreateDto employeeCreateDto);

        Task<EmployeeDto> UpdateAsync(Guid id, TEntityUpdateDto employee);

        Task<int> DeleteAsync(Guid id);

        Task<int> DeleteMultipleAsync(List<Guid> ids);
        Task GetListAsync(int page, int pageSize, string? employeeFilter);
    }
}
