using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.UOW;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    class ConstituRepository : IConstituRepository
    {
        private readonly DbSession _session;
        public ConstituRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from CONSTITUE where IdRepas = @IdRepas and IdIngr = @IdIngr";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Constitue>> GetAllAsync()
        {
            //var requete = @"select * from REPAS R  inner
            //                        join Constitue C on R.IdRepas = C.IdRepas  inner
            //                        join INGREDIENTS I on C.IdIngr = I.IdIngr"

        var stmt = @"select * from CONSTITUE";
            return await _session.Connection.QueryAsync<Constitue>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Constitue>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from CONSTITUE 
                       
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM CONSTITUE";

            IEnumerable<Constitue> clientTask = await _session.Connection.QueryAsync<Constitue>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Constitue>(pageRequest.Page, pageRequest.PageSize, countTask, clientTask.ToList());
        }

        public async Task<Constitue> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from CONSTITUE where IdRepas = @IdRepas and IdIngr = @IdIngr";
            return await _session.Connection.QueryFirstOrDefaultAsync<Constitue>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Constitue> InsertAsync(Constitue entity)
        {
            var stmt = @"insert into CONSTITUE(Quantite)  output INSERTED.IdClient
            values (@Quantite)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task UpdateAsync(Constitue entity)
        {
            var stmt = @"UPDATE  CONSTITUE SET Quantite= @Quantite  where IdRepas = @IdRepas and IdIngr = @IdIngr";
            await _session.Connection.QueryAsync<Constitue>(stmt, entity, _session.Transaction);
        }

    }
}
