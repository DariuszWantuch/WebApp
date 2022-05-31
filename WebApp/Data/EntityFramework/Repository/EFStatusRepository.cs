using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.EntityFramework.Repository.IRepository;

namespace WebApp.Data.EntityFramework.Repository
{
    public class EFStatusRepository : EFRepository<Status>, IEFStatusRepository
    {
        private readonly ApplicationDbContext _db;

        public EFStatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
