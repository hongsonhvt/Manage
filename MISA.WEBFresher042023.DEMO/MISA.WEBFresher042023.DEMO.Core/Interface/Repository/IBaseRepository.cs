using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Intuit.Ipp.Data;
using Intuit.Ipp.WebhooksService;

using MISA.WEBFresher042023.DEMO.Core.Entity;

namespace MISA.WEBFresher042023.DEMO.Core.Interface.Repository
{
    public  interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// Ham lay 1 ban ghi
        /// </summary>
        /// <param name="id"> Id cua ban ghi</param>
        /// <returns>Ban ghi</returns>
        /// Created by: nhson (20/6/2023)

        Task <TEntity?> GetAsync(Guid id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity?> InsertAsync(TEntity entity);
        Task<TEntity?> UpdateAsync(Guid id, TEntity entity);
        Task<int?> DeleteAsync(Guid id);
        Task<int?> DeleteMultipleTEntityAsync(List<Guid> ids);
    }
}
