using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Data.NH.Repository.IRepository;

namespace WebApp.Data.NH.Repository
{
    public class NHMarkRepository : NHRepository<Mark>, INHMarkRepository
    {
    }
}
