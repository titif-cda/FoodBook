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
            var type = typeof(T);

            switch(type)
            {
                case IMenuRepository: 
                    return new FakeMenuRepository() as T;

                default:
                    return default(T);
            }
        }

        public void Rollback()
        {
            return;
        }
    }
}
