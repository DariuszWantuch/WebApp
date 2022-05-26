using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;
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

        [HttpPost(Name = "SaveDataToDatabase")]
        public ActionResult SaveDataToDatabase()
        {
            try
            {
                RepairCost repairCost = new RepairCost();
                repairCost.Cost = 56;
                repairCost.FaultDescription = "TEST";
                repairCost.IsAccepted = false;
                repairCost.IsRejected = false;

                for (int i = 0; i < 10000; i++)
                {
                    
                }
            }
            catch (Exception ex)
            {
                Results.StatusCode(500);
            }
        }
    }
}
