using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFDeviceTypeRepository : EFRepository<DeviceType>, IEFDeviceTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public EFDeviceTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
