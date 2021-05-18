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
    class RepasRepository : IRepasRepository
    {
        private readonly DbSession _session;
        public RepasRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from REPAS where IdRepas = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<PageResponse<Repas>> GetAllAsync(PageRequest pageRequest, Filter filter)
        {
            var stmt = @"select * from REPAS 
                        ORDER BY IdRepas
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM REPAS";

            IEnumerable<Repas> booksTask = await _session.Connection.QueryAsync<Repas>(stmt, (pageRequest, filter), _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Repas>(pageRequest.Page, pageRequest.PageSize, countTask, (booksTask).ToList());
        }
        public async Task<IEnumerable<Repas>> GetAllAsync()
        {
            var stmt = @"select * from REPAS";
            return await _session.Connection.QueryAsync<Repas>(stmt, null, _session.Transaction);
        }

        public async Task<Repas> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from REPAS where IdRepas = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Repas>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Repas> InsertAsync(Repas entity)
        {
            var stmt = @"insert into REPAS(IdTypeRepas, LibelleRepas, DescRepas) output INSERTED.IdRepas
            values (@IdTypeRepas, @LibelleRepas, @DescRepas)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Repas entity)
        {
            var stmt = @"UPDATE  REPAS SET IdTypeRepas = @IdTypeRepas, LibelleRepas=  @LibelleRepas, DescRepas = @DescRepas WHERE IdRepas = @IdRepas";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }
}
