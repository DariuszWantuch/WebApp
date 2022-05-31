using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Threading.Tasks;
using WebApp.Data.NH.Repository.IRepository;
using NHibernate;
using ISession = NHibernate.ISession;

namespace WebApp.Data.NH.Repository
{
    public class NHRepository<T> : INHRepository<T> where T : class
    {
        public void Add(T obj)
        {
            using (ISession session = NH.OpenSession())
            using (ITransaction tran = session.BeginTransaction())
            {
                session.Save(obj);

                tran.Commit();
            }
        }

        public IEnumerable<T> GetAll()
        {

            List<T> obj;


            using (var session = NH.OpenSession())
            {
                obj = session.Query<T>().ToList();
            }

            return obj;
        }
    }
}
