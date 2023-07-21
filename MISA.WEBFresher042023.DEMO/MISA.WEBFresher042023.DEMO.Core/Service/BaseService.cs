using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;
using MISA.WEBFresher042023.DEMO.Core.Interface.Service;
using MISA.WEBFresher042023.DEMO.Core.MISAException;

namespace MISA.WEBFresher042023.DEMO.Core.Service
{
    public abstract class BaseService<TEntity, TEntityDto, TEntityCreateDto, TEntityUpdateDto> 
        : IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>
    {
        protected readonly IBaseRepository<TEntity> _baseRepository;
        protected readonly IMapper _mapper;
        protected BaseService(IBaseRepository<TEntity> baseRepository, IMapper mapper)
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        public Task<List<EmployeeDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntityDto> GetAsync(Guid id)
        {
            var entity = await _baseRepository.GetAsync(id);

            if (entity == null)
            {
                throw new NotFoundException();
            }
            var entityDto = _mapper.Map<TEntityDto>(entity);

            return entityDto;
    
        }

        public Task<EmployeeDto> InsertAsync(TEntityCreateDto employeeCreateDto)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityDto> UpdateAsync(Guid id, TEntityUpdateDto employee)
        {
            throw new NotImplementedException();
        }
        public async Task<int> DeleteAsync(Guid id)
        {
            var entity = await _baseRepository.GetAsync(id);

            if (entity == null)
            {
                throw new NotFoundException();
            }

            var result = await _baseRepository.DeleteAsync(id);
            return (int)result;
        }

        public Task<int> DeleteMultipleAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }

        Task<EmployeeDto> IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>.GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<EmployeeDto> IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto>.UpdateAsync(Guid id, TEntityUpdateDto employee)
        {
            throw new NotImplementedException();
        }
    }
}
