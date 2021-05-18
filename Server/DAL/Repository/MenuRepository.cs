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
    class MenuRepository : IMenuRepository
    {
        private readonly DbSession _session;
        public MenuRepository(DbSession dbSession)
        {
            _session = dbSession;
        }
        public async Task<int> DeleteAsync(long id)
        {
            var stmt = @"delete from MENU where IdMenu = @id";
            return await _session.Connection.ExecuteAsync(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<PageResponse<Menu>> GetAllAsync(PageRequest pageRequest)
        {
            var stmt = @"select * from MENU 
                        ORDER BY IdMenu
                        OFFSET @PageSize * (@Page - 1) rows
                        FETCH NEXT @PageSize rows only";
            string queryCount = " SELECT COUNT(*) FROM MENU";

            IEnumerable<Menu> MenuTask = await _session.Connection.QueryAsync<Menu>(stmt, pageRequest, _session.Transaction);
            int countTask = await _session.Connection.ExecuteScalarAsync<int>(queryCount, null, _session.Transaction);


            return new PageResponse<Menu>(pageRequest.Page, pageRequest.PageSize, countTask, (MenuTask).ToList());
        }
        public async Task<IEnumerable<Menu>> GetAllAsync()
        {
            var stmt = @"select * from MENU";
            return await _session.Connection.QueryAsync<Menu>(stmt, null, _session.Transaction);
        }

        public async Task<Menu> GetAsync(int id)
        {
            //Evité l'injection sql avec des reqêtes paramétrées
            var stmt = @"select * from MENU where IdMenu = @id";
            return await _session.Connection.QueryFirstOrDefaultAsync<Menu>(stmt, new { Id = id }, _session.Transaction);
        }

        public async Task<Menu> InsertAsync(Menu entity)
        {
            var stmt = @"insert into MENU(DateMenu, NomMenu, ListPlats) output INSERTED.IdMenu
            values (@DateMenu, @NomMenu, @ListPlats)";
            int i = await _session.Connection.QuerySingleAsync<int>(stmt, entity, _session.Transaction);
            return await GetAsync(i);
        }

        public async Task<bool> UpdateAsync(Menu entity)
        {
            var stmt = @"UPDATE  MENU SET DateMenu = @DateMenu, NomMenu=  @NomMenu, ListPlats = @ListPlats WHERE IdMenu = @IdMenu";
            var nbModifiedLines = await _session.Connection.ExecuteAsync(stmt, entity, _session.Transaction);
            return nbModifiedLines > 0;
        }
    }

}
