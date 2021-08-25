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
    internal class FakeMenuRepository : IServiceRepository
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

        public Task<PageResponse<Service>> GetAllAsync(PageRequest pageRequest)
        {
            return Task.FromResult(new PageResponse<Service>()
            {
               Page = pageRequest.Page,
               PageSize = pageRequest.PageSize,
               Data = new List<Service>(),
               TotalRecords = 100
            });
        }

        public Task<IEnumerable<Service>> GetAllAsync()
        {
           return Task.FromResult<IEnumerable<Service>>(new List<Service>());
        }

        public Task<Service> GetAsync(int id)
        {
            Service Test = new Service();
            if (id != 0)
                return Task.FromResult(Test);
            else
                return Task.FromResult<Service>(null);
        }

        public Task<Service> GetMetForServiceAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Service> GetServiceByDateAndService(DateTime date, bool midi)
        {
            throw new NotImplementedException();
        }

        public Task<Service> InsertAsync(Service entity)
        {
            if(entity == null)
            {
                return Task.FromResult<Service>(null);
            }
            else
            {
                entity.Id = 1;
                return Task.FromResult(entity);
            }
        }

        public Task<Service> UpdateAllAsync(Service entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Service entity)
        {
            if (entity == null)
            {
                throw new Exception();
            }
            else if (entity.Id == 0)
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