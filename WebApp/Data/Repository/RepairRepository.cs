using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository
{
    public class RepairRepository : Repository<Repair>, IRepairRepository
    {
        private readonly ApplicationDbContext _db;

        public RepairRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Repair repair)
        {
            var obj = _db.Repair.FirstOrDefault(s => s.Id == repair.Id);

            obj.Describe = repair.Describe;
            obj.DeviceModel = repair.DeviceModel;
            obj.Warranty = repair.Warranty;
            obj.MarkId = repair.MarkId;
            obj.PickupDate = repair.PickupDate;

            _db.SaveChanges();
        }
    }
}
