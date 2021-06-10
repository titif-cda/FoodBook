﻿using BO.DTO.Requests;
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
    class MetRepository : IMetsRepository
    {
        private readonly DbSession _session;
        public MetRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Mets where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Met>> GetAllAsync()
        {
            var stmt = @"select * from Mets";
            return await _session.Connection.QueryAsync<Met>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Met>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Mets 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Mets";

            IEnumerable<Met> metTask = await _session.Connection.QueryAsync<Met>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Met>(pageRequest.Page, pageRequest.PageSize, countTask, metTask.ToList());
        }

        public async Task<Met> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Mets where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Met>(stmt, new { Id = id }, _session.Transaction);

        }
        public async Task<Met> GetIngredientForMetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt1 = @"select * from IngredientsParPlats WHERE Id = @id;";
            var stmt = @"select p.Id, p.Libelle, mi.IdMet, mi.Quantite, i.Id, i.Nom, i.Prix from Mets as p 
					 inner join MetsIngredients as mi on p.Id = mi.IdMet
					 inner join Ingredient as i on mi.IdIngredient = i.Id WHERE p.Id = @id;";
            // Renvoie une ligne pour chaque ingredient et pour chaque id met
            var mets = await _session.Connection.QueryAsync<Met, MetsIngredients, Ingredient, Met >(stmt, (met, metIngredient, ingredient) =>
            {
                met.ListDesIngredients = met.ListDesIngredients ?? new List<MetsIngredients>();
                metIngredient.Ingredient = ingredient;

                met.ListDesIngredients.Add(metIngredient);
                return met;
            }, new { Id = id }, transaction: _session.Transaction, splitOn: "Id, IdMet, Id");
         //Regroupe les ingredients dans une liste pour un id met
            var met = mets.GroupBy(m => m.Id).Select(m =>
            {
                var met = m.First();
                met.ListDesIngredients = m.Select(mp => mp.ListDesIngredients.Single()).ToList();
                return met;
            }).FirstOrDefault();
           //Renvoie le met avec la liste de ses ingredients
            return met;
            

        }

        public async Task<Met> InsertAsync(Met entity)
        {
            var stmt = @"insert into Mets( IdType, Libelle , Description)  output INSERTED.Id
            values (@IdType, @Libelle, @Description)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Met entity)
        {
            var stmt = @"UPDATE Mets SET IdType = @IdType, Libelle = @Libelle, Description=@Description WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }
}
