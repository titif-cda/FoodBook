using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    internal class FakeMenuRepository : IMenuRepository
    {
        public FakeMenuRepository() 
        {
        }



        public Task<int> DeleteAsync(long id)
        {
            //
            if (id > 10)
                return Task.FromResult(0);
            else 
                return Task.FromResult(1);
        }

        public Task<PageResponse<Menu>> GetAllAsync(PageRequest pageRequest)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Menu>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Menu> GetAsync(int id)
        {
            Menu Test = new Menu();
            if (id != 0)
                return Task.FromResult<Menu>(Test);
            else
                return Task.FromResult<Menu>(null);
        }

        public Task<Menu> InsertAsync(Menu entity)
        {
            throw new System.NotImplementedException();
        }

        public Task UpdateAsync(Menu entity)
        {
            throw new System.NotImplementedException();
        }
    }
}