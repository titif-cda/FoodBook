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
    class TypeRepasRepository : ITypeRepasRepository
    {
        private readonly DbSession _session;
        public TypeRepasRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public  async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from TypeRepas where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<PageResponse<TypeRepas>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from TypeRepas
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM TypeRepas";

            IEnumerable<TypeRepas> TypeRepasTask = await _session.Connection.QueryAsync<TypeRepas>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<TypeRepas>(pageRequest.Page, pageRequest.PageSize, countTask, TypeRepasTask.ToList());
        }

        public async Task<IEnumerable<TypeRepas>> GetAllAsync()
        {
            var stmt = @"select * from TypeRepas";
            return await _session.Connection.QueryAsync<TypeRepas>(stmt, null, _session.Transaction);
        }

        public async Task<TypeRepas> GetAsync(int id)
        {
            var stmt = @"select * from TypeRepas where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<TypeRepas>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<TypeRepas> InsertAsync(TypeRepas entity)
        {
            var stmt = @"insert into TypeRepas( Libelle)  output INSERTED.id
            values (@Libelle)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(TypeRepas entity)
        {
            var stmt = @"UPDATE  TypeRepas Libelle = @Libelle WHERE Id = @id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }
}
