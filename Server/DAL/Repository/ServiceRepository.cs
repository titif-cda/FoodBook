using BO.Entity;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using BO.DTO.Responses;
using BO.DTO.Requests;

namespace DAL.Repository
{
    class ServiceRepository : IServiceRepository
    {
        private readonly DbSession _session;
        public ServiceRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Service where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<PageResponse<Service>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Service 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Service";

            IEnumerable<Service> MenuTask = await _session.Connection.QueryAsync<Service>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Service>(pageRequest.Page, pageRequest.PageSize, countTask, (MenuTask).ToList());
        }
        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            var stmt = @"select * from Service";
            return await _session.Connection.QueryAsync<Service>(stmt, null, _session.Transaction);
        }

        public async Task<Service> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Service where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Service>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Service> InsertAsync(Service entity)
        {
            var stmt = @"insert into Service(Date, Midi) output INSERTED.Id
            values (@DateMenu, @Midi)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Service entity)
        {
            var stmt = @"UPDATE  Service SET Date = @DateMenu, Midi=  @Midi WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }

}
