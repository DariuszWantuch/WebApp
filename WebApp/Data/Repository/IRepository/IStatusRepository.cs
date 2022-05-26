using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository.IRepository
{
    public interface IStatusRepository : IRepository<Status>
    {
        string GetStatusIdByName(string name);
        IEnumerable<SelectListItem> GetStatusListFromDropDown();
    }
}
