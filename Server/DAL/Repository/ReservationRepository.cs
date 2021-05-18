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

        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from RESERVATION where IdResa = @IdResa";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<IEnumerable<Reservation>> GetAllAsync()
        {
            var stmt = @"select * from RESERVATION";
            return await _session.Connection.QueryAsync<Reservation>(stmt, null, _session.Transaction);
        }

        public async Task<PageResponse<Reservation>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from RESERVATION 
                        ORDER BY IdResa
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM RESERVATION";

            IEnumerable<Reservation> clientTask = await _session.Connection.QueryAsync<Reservation>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Reservation>(pageRequest.Page, pageRequest.PageSize, countTask, clientTask.ToList());
        }

        public async Task<Reservation> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from RESERVATION where IdResa = @IdResa";
            return await _session.Connection.QueryFirstOrDefaultAsync<Reservation>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Reservation> InsertAsync(Reservation entity)
        {
            var stmt = @"insert into RESERVATION(IdClient, IdMenu, DateResa, NbResa, FormMatin, FormMidi, FormSoir)  output INSERTED.IdResa
            values ( @IdClient, @IdMenu, @DateResa, @NbResa, @FormMatin, @FormMidi, @FormSoir)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Reservation entity)
        {
            var stmt = @"UPDATE  RESERVATION SET IdClient = @IdClient, IdMenu=@IdMenu, DateResa= @DateResa, NbResa = @NbResa,
                FormMatin = @FormMatin, FormMidi = @FormMidi, FormSoir = @FormSoir WHERE IdResa = @IdResa";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }

    }
}
