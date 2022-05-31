using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFRepairRepository : EFRepository<Repair>, IEFRepairRepository
    {
        private readonly ApplicationDbContext _db;

        public EFRepairRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
