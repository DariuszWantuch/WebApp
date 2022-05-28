using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NHibernateController : Controller
    {
        
        public NHibernateController()
        {
          
        }

        [HttpGet, Route("Test")]
        public ActionResult Test()
        {
            return Ok();
        }       
    }
}
