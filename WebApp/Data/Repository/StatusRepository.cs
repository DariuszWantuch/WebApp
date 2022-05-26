﻿using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Data.Repository.IRepository;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository
{
    public class StatusRepository : Repository<Status>, IStatusRepository
    {
        private readonly ApplicationDbContext _db;

        public StatusRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public string GetStatusIdByName(string name)
        {
            var obj = _db.Status.FirstOrDefault(x => x.RepairStatus == name);
            return obj.Id;
        }

        public IEnumerable<SelectListItem> GetStatusListFromDropDown()
        {
            return _db.Status.Select(i => new SelectListItem()
            {
                Text = i.RepairStatus,
                Value = i.Id.ToString()
            });
        }
    }
}
