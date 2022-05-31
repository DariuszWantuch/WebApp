using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFUnitOfWork : IEFUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public EFUnitOfWork(ApplicationDbContext db)
        {
            _db = db;          
            Mark = new EFMarkRepository(_db);
            Repair = new EFRepairRepository(_db);
            Status = new EFStatusRepository(_db);
            Address = new EFAddressRepository(_db);
            RepairCost = new EFRepairCostRepository(_db);
            DeviceType = new EFDeviceTypeRepository(_db);
            User = new EFUserRepository(_db);

        }
        
        public IEFMarkRepository Mark { get; private set; }
        public IEFRepairRepository Repair { get; private set; }
        public IEFStatusRepository Status { get; private set; }
        public IEFAddressRepository Address { get; private set; }
        public IEFRepairCostRepository RepairCost { get; private set; }
        public IEFDeviceTypeRepository DeviceType { get; private set; }
        public IEFUserRepository User { get; private set; }

        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
