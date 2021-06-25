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

        public async Task<PageResponse<Met>> GetAllAsync(FilterMetPaged filterMetPaged)
        {
            var whereClause = "";
            var orderBy = "order by m.Id";
            if (filterMetPaged.typeRepasId != null)
            {
                whereClause = "Where tp.Id = @typeRepasID";
            }

            if(filterMetPaged.Recherche != null)
            {
                if(whereClause != "")
                {
                    whereClause += " And";
                }else
                {
                    whereClause += " Where";
                }

                var temp = "%" + filterMetPaged.Recherche + "%";

                filterMetPaged.Recherche = temp;
                whereClause += " i.Nom LIKE(@Recherche)"; 
            }

            if(filterMetPaged.Popularite != 0)
            {
                
                orderBy = "order by NombreResa " + ((filterMetPaged.Popularite > 0) ? "ASC" : "DESC");
            }

            var stmt = @$"select distinct m.Id, m.Libelle, tp.Id, tp.Libelle, (select COALESCE(sum(Nb), 0) from Reservation r 
                                                    join ServiceMets sm on r.IdService= sm.IdService
	                                                join Mets mInter on sm.IdMet = mInter.Id where mInter.Id = m.Id) as NombreResa 
                            from Mets as m 
                            inner join MetsIngredients as mi on m.Id  = mi.IdMet
	                        inner join Ingredient as i on mi.IdIngredient = i.Id 
	                        inner join TypeRepas tp on m.IdType=tp.Id 
                            { whereClause} {orderBy}
                            OFFSET @PageSize * (@Page - 1) rows
                            FETCH NEXT @PageSize rows only
                            ";
            

            string queryCount = " SELECT COUNT(*) FROM Mets m inner join TypeRepas tp on m.IdType = tp.Id ";

           IEnumerable<Met> mets = await _session.Connection.QueryAsync<Met, TypeRepas, Met>(stmt,(met, typeRepas)=>{
               met.TypeRepas = typeRepas;
               return met;
           
           }, filterMetPaged, _session.Transaction);
            
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);
            //var metsGrouped = mets.GroupBy(m => m.Id).Select(m =>
            //{
            //    var met = m.First();
            //    if (met.ListDesIngredients.Count() > 0)
            //        met.ListDesIngredients = m.Select(mp => mp.ListDesIngredients.Single()).ToList();
            //    return met;
            //});

            return new PageResponse<Met>(filterMetPaged.Page, filterMetPaged.PageSize, countTask, mets.ToList());
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
            var stmt = @"select p.Id, p.Libelle, p.Description, mi.IdMet, mi.Quantite,tp.Id, tp.Libelle, i.Id, i.Nom, i.Prix from Mets as p 
					 left join MetsIngredients as mi on p.Id = mi.IdMet
                     left join TypeRepas tp on p.IdType = tp.Id
					 left join Ingredient as i on mi.IdIngredient = i.Id WHERE p.Id = @id;";
            // Renvoie une ligne pour chaque ingredient et pour chaque id met
            var mets = await _session.Connection.QueryAsync<Met, MetsIngredients, TypeRepas, Ingredient, Met >(stmt, (met, metIngredient, typeRepas, ingredient) =>
            {
                met.TypeRepas = typeRepas;
                met.ListDesIngredients = met.ListDesIngredients ?? new List<MetsIngredients>();
                if(metIngredient != null)
                {
                    metIngredient.Ingredient = ingredient;
                    met.ListDesIngredients.Add(metIngredient);
                }

                return met;
            }, new { Id = id }, transaction: _session.Transaction, splitOn: "Id, IdMet, Id, Id");
         //Regroupe les ingredients dans une liste pour un id met
            var met = mets.GroupBy(m => m.Id).Select(m =>
            {
                var met = m.First();
                if(met.ListDesIngredients.Count() > 0)
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
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, new { 
                IDtype = entity.TypeRepas.Id,
                Libelle = entity.Libelle,
                Description = entity.Description
            }, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Met entity)
        {
            var stmt = @"UPDATE Mets SET IdType = @IdType, Libelle = @Libelle, Description = @Description WHERE Id = @Id";

            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, new {
            IdType = entity.TypeRepas.Id,
            Libelle = entity.Libelle,
            Description =entity.Description,
            Id =entity.Id
            }, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }
}
