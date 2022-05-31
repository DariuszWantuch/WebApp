using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.NH.Repository.IRepository
{
    public interface INHUnitOfWork
    {    
        INHMarkRepository Mark { get; }
        INHRepairRepository Repair { get; }
        INHStatusRepository Status { get; }
        INHAddressRepository Address { get; }
        INHRepairCostRepository RepairCost { get; }
        INHDeviceTypeRepository DeviceType { get; }
        INHUserRepository User { get; }
    }
}
