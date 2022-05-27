using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Data.Repository.IRepository;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityFrameworkController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EntityFrameworkController> _logger;

        public EntityFrameworkController(ILogger<EntityFrameworkController> logger, IUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        [HttpGet, Route("Test")]
        public ActionResult Test()
        {
            return Ok();
        }

        [HttpPost, Route("SaveDataToDatabase")]
        public ActionResult SaveDataToDatabase()
        {
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    RepairCost repairCost = new RepairCost();
                    repairCost.Cost = i;
                    repairCost.FaultDescription = "TEST";
                    repairCost.IsAccepted = false;
                    repairCost.IsRejected = false;

                    _context.RepairCost.Add(repairCost);
                    _context.SaveChanges();
                }

                return StatusCode(200, "Dodano rekordy");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Wystąpił błąd: {ex}");
            }
        }
    }
}
