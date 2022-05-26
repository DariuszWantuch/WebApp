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
        void Update(Mark mark);
    }
}
