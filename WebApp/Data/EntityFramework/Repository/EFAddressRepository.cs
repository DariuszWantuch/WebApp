using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFAddressRepository : EFRepository<Address>, IEFAddressRepository
    {
        private readonly ApplicationDbContext _db;

        public EFAddressRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
