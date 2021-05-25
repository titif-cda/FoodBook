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
    internal class ClientRepository : IClientRepository
    {
        private readonly DbSession _session;
        public ClientRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Client where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            var stmt = @"select * from Client";
            return await _session.Connection.QueryAsync<Client>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Client>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Client 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Client";

            IEnumerable<Client> clientTask = await _session.Connection.QueryAsync<Client>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Client>(pageRequest.Page, pageRequest.PageSize, countTask, clientTask.ToList());
        }

        public async Task<Client> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Client where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Client>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Client> InsertAsync(Client entity)
        {
            var stmt = @"insert into Client( Nom , Prenom, Tel, Email)  output INSERTED.Id
            values (@Nom, @Prenom, @Tel, @Email)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Client entity)
        {
            var stmt = @"UPDATE Client SET Nom = @Nom, Prenom=@Prenom, Tel= @Tel,Email = @Email WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }

    }
}
