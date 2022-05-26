using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository.IRepository
{
    public interface IRepairRepository : IRepository<Repair>
    {

        int RepairID();
        void ChangeRepairStatus(string repairId, string statusId);
        void Update(Repair repair);
    }
}
