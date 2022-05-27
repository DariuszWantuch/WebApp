using Microsoft.AspNetCore.Mvc;

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
