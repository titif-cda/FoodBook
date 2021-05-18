using BO.DTO.Requests;
using BO.DTO.Responses;
using BO.Entity;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return Task.FromResult(new PageResponse<Menu>()
            {
               Page = pageRequest.Page,
               PageSize = pageRequest.PageSize,
               Data = new List<Menu>(),
               TotalRecords = 100
            });
        }

        public Task<IEnumerable<Menu>> GetAllAsync()
        {
           return Task.FromResult<IEnumerable<Menu>>(new List<Menu>());
        }

        public Task<Menu> GetAsync(int id)
        {
            Menu Test = new Menu();
            if (id != 0)
                return Task.FromResult(Test);
            else
                return Task.FromResult<Menu>(null);
        }

        public Task<Menu> InsertAsync(Menu entity)
        {
            if(entity == null)
            {
                return Task.FromResult<Menu>(null);
            }
            else
            {
                entity.IdMenu = 1;
                return Task.FromResult(entity);
            }
        }

        public Task<bool> UpdateAsync(Menu entity)
        {
            if (entity == null)
            {
                throw new Exception();
            }
            else if (entity.IdMenu == null)
            {
                return Task.FromResult(false);
            }
            else
            {
                return Task.FromResult(true);
            }
        }
    }
}