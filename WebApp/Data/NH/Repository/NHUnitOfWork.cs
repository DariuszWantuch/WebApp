using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.NH.Repository.IRepository;

namespace WebApp.Data.NH.Repository
{
    public class NHUnitOfWork : INHUnitOfWork
    {
        public NHUnitOfWork()
        {
            Mark = new NHMarkRepository();
            Repair = new NHRepairRepository();
            Status = new NHStatusRepository();
            Address = new NHAddressRepository();
            RepairCost = new NHRepairCostRepository();
            DeviceType = new NHDeviceTypeRepository();
            User = new NHUserRepository();

        }
        
        public INHMarkRepository Mark { get; private set; }
        public INHRepairRepository Repair { get; private set; }
        public INHStatusRepository Status { get; private set; }
        public INHAddressRepository Address { get; private set; }
        public INHRepairCostRepository RepairCost { get; private set; }
        public INHDeviceTypeRepository DeviceType { get; private set; }
        public INHUserRepository User { get; private set; }
    }
}
