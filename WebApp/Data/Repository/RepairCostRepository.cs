using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository
{
    public class RepairCostRepository : Repository<RepairCost>, IRepairCostRepository
    {
        private readonly ApplicationDbContext _db;

        public RepairCostRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
