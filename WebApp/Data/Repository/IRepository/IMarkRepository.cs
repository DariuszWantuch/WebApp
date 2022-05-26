using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data.Repository.IRepository
{
    public interface IMarkRepository : IRepository<Mark>
    {
        IEnumerable<SelectListItem> GetMarkListFromDropDown();

        void Update(Mark mark);

        public bool IsMarkExist(string name);
    }
}
