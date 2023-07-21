using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dapper;

using Intuit.Ipp.Data;

using Microsoft.Extensions.Configuration;

using MISA.WEBFresher042023.DEMO.Core.Entity;
using MISA.WEBFresher042023.DEMO.Core.Interface.Repository;

using MySqlConnector;

namespace MISA.WEBFresher042023.DEMO.Infrastructure.Reponsitory
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
    {
        protected readonly string? _connectionString;
        public BaseRepository(IConfiguration configuration)
        {
            _connectionString = configuration["ConnectionString"];
        }
        public Task<List<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity?> GetAsync(Guid id)
        {
            var tableName = typeof(TEntity).Name;
            var param = new DynamicParameters();
            param.Add("Id", id);
            var sql = $"SELECT * FROM {tableName} WHERE {tableName} = @Id";
            var mySqlConnection = new MySqlConnection(_connectionString);
            await mySqlConnection.OpenAsync();
            var employee = await mySqlConnection.QueryFirstOrDefaultAsync<TEntity>(sql, param);         
            await mySqlConnection.CloseAsync();
            return employee;
        }

        public Task<TEntity?> InsertAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity?> UpdateAsync(Guid id, TEntity entity)
        {
            throw new NotImplementedException();
        }
        public async Task<int?> DeleteAsync(Guid id)
        {
            var tableName = typeof(TEntity).Name;

            var mySqlConnection = new MySqlConnection(_connectionString);

            await mySqlConnection.OpenAsync();

            var param = new DynamicParameters();

            param.Add("Id", id);

            var sql = $"DELETE FROM {tableName} WHERE {tableName}Id = @Id";


            var resuilt = await mySqlConnection.ExecuteAsync(sql, param);

            await mySqlConnection.CloseAsync();

            return resuilt;
        }

        public Task<int?> DeleteMultipleTEntityAsync(List<Guid> ids)
        {
            throw new NotImplementedException();
        }
    }
}
