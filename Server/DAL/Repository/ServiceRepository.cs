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
    internal class ServiceRepository : IServiceRepository
    {
        private readonly DbSession _session;
        public ServiceRepository (DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Service where Id = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            var stmt = @"select * from Met";
            return await _session.Connection.QueryAsync<Service>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Service>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from Service 
                        ORDER BY Id
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Service";

            IEnumerable<Service> serviceTask = await _session.Connection.QueryAsync<Service>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Service>(pageRequest.Page, pageRequest.PageSize, countTask, serviceTask.ToList());
        }



        public async Task<Service> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from Service where Id = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Service>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Service> GetMetForServiceAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            
            var req = @" select s.Midi, s.Date, s.Id, m.Id, m.Libelle, tp.Id, tp.Libelle from Service as s 
                left join ServiceMets as sm on sm.IdService = s.Id 
                left join Mets as m on sm.IdMet = m.Id 
                left join TypeRepas as tp on m.IdType = tp.Id where s.Id = @id;";

            // Renvoie une ligne pour chaque ingredient et pour chaque id met
            var services = await _session.Connection.QueryAsync<Service, Met, TypeRepas, Service>(req, (service, met, typeRepas) =>
             {
                 met.TypeRepas = typeRepas;
                 service.ListPlats = service.ListPlats ?? new List<Met>();
                 service.ListPlats.Add(met);
                // met.ListDesIngredients = met.ListDesIngredients ?? new List<MetsIngredients>();
                //if (serviceMet != null)
                // {
                //     serviceMet.Met = met;
                //     service.ListPlats.Add(met);
                // }

                 return service;
             }, new { Id = id }, transaction: _session.Transaction, splitOn: "Id");
            
            //Regroupe les plats dans une liste pour un id service
            var service = services.GroupBy(s => s.Id).Select(s =>
            {
                var service = s.First();
                if (service.ListPlats.Count() > 0)
                    service.ListPlats = s.Select(mp => mp.ListPlats.Single()).ToList();
                return service;
            }).FirstOrDefault();
            //Renvoie le service avec la liste de ses plats
            return service;
        }

        public async Task<IEnumerable<Service>> GetServiceByDate(DateTime date )
        {
            //Evité l'injection sql avec des reqêtes paramétrées

            var req = @" select s.Midi, s.Date, s.Id, m.Id, m.Libelle, tp.Id, tp.Libelle from Service as s 
                left join ServiceMets as sm on sm.IdService = s.Id 
                left join Mets as m on sm.IdMet = m.Id 
                left join TypeRepas as tp on m.IdType = tp.Id where s.Date = @date;";

            // Renvoie une ligne pour chaque ingredient et pour chaque id met
            var services = await _session.Connection.QueryAsync<Service, Met, TypeRepas, Service>(req, (service, met, typeRepas) =>
            {
                met.TypeRepas = typeRepas;
                service.ListPlats = service.ListPlats ?? new List<Met>();
                service.ListPlats.Add(met);
                // met.ListDesIngredients = met.ListDesIngredients ?? new List<MetsIngredients>();
                //if (serviceMet != null)
                // {
                //     serviceMet.Met = met;
                //     service.ListPlats.Add(met);
                // }

                return service;
            }, new { Date = date }, transaction: _session.Transaction, splitOn: "Id");

            //Regroupe les plats dans une liste pour un id service
            var service = services.GroupBy(s => s.Id).Select(s =>
            {
                var service = s.First();
                if (service.ListPlats.Count() > 0)
                    service.ListPlats = s.Select(mp => mp.ListPlats.Single()).ToList();
                return service;
            });
            //Renvoie le service avec la liste de ses plats
            return service;
        }


        public async Task<Service> InsertAsync(Service entity)
        {
            var stmt = @"insert into Service( Midi , Date)  output INSERTED.Id
            values (@Midi, @Date)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            //Ajout des plats liés
            List<Met> listeMets = entity.ListPlats;

            var req = @"INSERT INTO ServiceMets(IdService, IdMet) VALUES(@idService, @idMet)";

            foreach (var met in listeMets)
            {
                await _session.Connection.QueryAsync(req, param: new { idService=i, idMet = met.Id}, _session.Transaction);
            }
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Service entity)
        {
            var stmt = @"UPDATE Service SET Midi = @Midi, Date=@Date WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }
}
