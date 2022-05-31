using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.EntityFramework.Repository.IRepository
{
    public interface IEFUnitOfWork : IDisposable
    {    
        IEFMarkRepository Mark { get; }
        IEFRepairRepository Repair { get; }
        IEFStatusRepository Status { get; }
        IEFAddressRepository Address { get; }
        IEFRepairCostRepository RepairCost { get; }
        IEFDeviceTypeRepository DeviceType { get; }
        IEFUserRepository User{ get; }

        void Save();
    }
}
