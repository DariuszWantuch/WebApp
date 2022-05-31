using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebApp.Data.NH.Repository.IRepository
{
    public interface INHRepository<T> where T : class
    {
        IEnumerable<T> GetAll();

        void Add(T entity);
    }
}
