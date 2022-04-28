using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Services;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AppController : ControllerBase
    {
        AppService _appService;
        private readonly ILogger<AppController> _logger;

        public AppController(AppService appService, ILogger<AppController> logger)
        {
            _appService = appService;
            _logger = logger;
        }

        [HttpGet(Name = "Test")]
        public ActionResult Test()
        {
            return Ok();
        }
    }
}
