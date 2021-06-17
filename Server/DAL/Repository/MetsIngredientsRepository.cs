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
    internal class MetsIngredientsRepository : IMetsIngredientsRepository
    {
        private readonly DbSession _session;
        public MetsIngredientsRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from MetsIngredients where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<MetsIngredients>> GetAllAsync()
        {
            var stmt = @"select * from MetsIngredients";
            return await _session.Connection.QueryAsync<MetsIngredients>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<MetsIngredients>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from MetsIngredients 
                        ORDER BY IdMet
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM MetsIngredients";

            IEnumerable<MetsIngredients> ingredientTask = await _session.Connection.QueryAsync<MetsIngredients>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);
            return new PageResponse<MetsIngredients>(pageRequest.Page, pageRequest.PageSize, countTask, (ingredientTask).ToList());
        }

        public async Task<MetsIngredients> GetAsync(int id)
        {
            var stmt = @"select * from MetsIngredients where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<MetsIngredients>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<MetsIngredients> InsertAsync(MetsIngredients entity)
        {
            var stmt = @"insert into MetsIngredients (Quantite, IdIngredient, IdMet)
            values (@Quantite, @IdIngredient, @IdMet)";
            await _session.Connection.ExecuteAsync(stmt, new { Quantite= entity.Quantite, IdIngredient = entity.Ingredient.Id, IdMet = entity.IdMet }, _session.Transaction);
            return entity;
        }

        public async Task<bool> UpdateAsync(MetsIngredients entity)
        {
            var stmt = @"UPDATE MetsIngredients SET Quantite = @Quantite, IdIngredient = @IdIngredient, IdMet= @IdMet WHERE IdIngredient = @IdIngredient and IdMet= @IdMet";
            await _session.Connection.QueryAsync<Ingredient>(stmt, new {
                Quantite = entity.Quantite,
                IdIngredient = entity.Ingredient.Id,
                IdMet=entity.IdMet
                }, _session.Transaction);
            return true;
        }
    }
}
