using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository
{
    public class MarkRepository : Repository<Mark>, IMarkRepository
    {
        private readonly ApplicationDbContext _db;

        public MarkRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Mark mark)
        {
            var obj = _db.Mark.FirstOrDefault(x => x.Id == mark.Id);

            obj.MarkName = mark.MarkName;

            _db.SaveChanges();
        }
    }
}
