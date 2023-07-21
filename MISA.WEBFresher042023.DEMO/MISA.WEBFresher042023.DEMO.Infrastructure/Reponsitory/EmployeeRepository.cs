using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

using Microsoft.Extensions.Configuration;

using MISA.WEBFresher042023.DEMO.Core.Dto;
using MISA.WEBFresher042023.DEMO.Core.Entity;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;
using MySqlConnector;

namespace MISA.WEBFresher042023.DEMO.Infrastructure.Reponsitory
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public Task<bool> IsDuplicateAsync(string code)
        {
            throw new NotImplementedException();
        }
    }
}
