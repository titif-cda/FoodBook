using DAL.Repository;
using DAL.UOW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.Services
{
    class FakeUnitOfWork : IUnitOfWork
    {

        public void BeginTransaction()
        {
            return;
        }

        public void Commit()
        {
            return;
        }

        public void Dispose()
        {
            return;
        }

        public T GetRepository<T>() where T : class
        {
            Type type = typeof(T);
           
            if(type == typeof(IMenuRepository))
            {
                return new FakeMenuRepository() as T;
            }
            else if( type == typeof(IClientRepository))
            {
            
                //TODO: Create Fake client repository
                return null;
            }
            return null;
        }

        public void Rollback()
        {
            return;
        }
    }
}
