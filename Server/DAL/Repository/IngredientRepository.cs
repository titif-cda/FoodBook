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
    internal class IngredientRepository : IIngredientRepository
    {
        private readonly DbSession _session;
        public IngredientRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Ingredient where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<PageResponse<Ingredient>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Ingredient 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Ingredient";

            IEnumerable<Ingredient> ingredientTask = await _session.Connection.QueryAsync<Ingredient>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Ingredient>(pageRequest.Page, pageRequest.PageSize, countTask, (ingredientTask).ToList());
        }
        public async Task<IEnumerable<Ingredient>> GetAllAsync()
        {
            var stmt = @"select * from Ingredient";
            return await _session.Connection.QueryAsync<Ingredient>(stmt, null, _session.Transaction);
        }

        public async Task<Ingredient> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Ingredient where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Ingredient>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Ingredient> InsertAsync(Ingredient entity)
        {
            var stmt = @"insert into Ingredient(Nom, Prix) output INSERTED.Id
            values (@Nom, @Prix)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

       

        public async Task<bool> UpdateAsync(Ingredient entity)
        {
            var stmt = @"UPDATE  Ingredient SET Nom = @Nom, Prix= @Prix WHERE Id = @Id";
            await _session.Connection.QueryAsync<Ingredient>(stmt, entity, _session.Transaction);
            return true;
        }
   }
}
