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
    class ReservationRepository : IReservationRepository
    {
        private readonly DbSession _session;
        public ReservationRepository(DbSession dbSession)
        {
            _session = dbSession;
        }

        public async Task<Reservation> GetAsync(int id)
        {
            var stmt = @"select R.Id, R.Date, R.Nb, R.Entree, R.Plat, R.Dessert, C.Id, C.Nom, C.Prenom, S.Id, S.Midi, S.Date  from Reservation R 
                        inner join Client as C on R.IdClient = C.Id
                        inner join Service as S on R.IdService = S.Id
                        Where R.Id = @id";
            var reservations = await _session.Connection.QueryAsync<Reservation, Client, Service, Reservation>(stmt, (reservation, client, service) =>
            {
                reservation.Client = client;
                reservation.Service = service;
                return reservation;

            }, new { Id = id }, transaction: _session.Transaction, splitOn: "Id");

            return reservations.FirstOrDefault();

        }

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from Reservation where Id= @Id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            var stmt = @"select * from Reservation";
            return await _session.Connection.QueryAsync<Reservation>(stmt, null, _session.Transaction);
        }

       
        public async Task<PageResponse<Reservation>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select R.Id, R.Date, R.Nb, R.Entree, R.Plat, R.Dessert, C.Id, C.Nom, C.Prenom, S.Id  from Reservation R 
                        inner join Client as C on R.IdClient = C.Id
                        inner join Service as S on R.IdService = S.Id
                        ORDER BY Date desc
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM Reservation";

            IEnumerable<Reservation> reservationTask = await _session.Connection.QueryAsync<Reservation,Client,Service,Reservation>(stmt, (reservation,client,service) =>
            {

                reservation.Client = client;
                reservation.Service = service;
                return reservation;

            }, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Reservation>(pageRequest.Page, pageRequest.PageSize, countTask, reservationTask.ToList());
        }

        public async Task<Reservation> InsertAsync(Reservation entity)
        {
            var stmt = @"insert into RESERVATION(IdClient, IdService, Date, Nb, Entree, Plat, Dessert)  output INSERTED.Id
            values ( @IdClient, @IdService, @Date, @Nb, @Entree, @Plat, @Dessert)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Reservation entity)
        {
            var stmt = @"UPDATE  Reservation SET IdClient = @IdClient, IdService=@IdService, Date = @Date, Nb = @Nb, Entree = @Entree ,Plat=@Plat ,Dessert= @Dessert WHERE Id = @Id";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }

    }
}
