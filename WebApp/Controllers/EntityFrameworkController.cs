using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Data.EntityFramework;
using WebApp.Data.EntityFramework.Repository.IRepository;
using WebApp.Models;
using WebApp.Services;
using Timer = System.Timers.Timer;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityFrameworkController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IEFUnitOfWork _unitOfWork;
        private readonly AppService _appService;

        public EntityFrameworkController(AppService appService, IEFUnitOfWork unitOfWork, ApplicationDbContext context)
        {
            _context = context;
            _unitOfWork = unitOfWork;
            _appService = appService;
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
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                for (int i = 0; i < 5000; i++)
                {
                    var repair = _appService.GetRepair();

                    _unitOfWork.Repair.Add(repair);
                }

                _unitOfWork.Save();

                stopwatch.Stop();

                var time = stopwatch.ElapsedMilliseconds;

                return StatusCode(200, "Dodano rekordy");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Wystąpił błąd: {ex}");
            }
        }

        [HttpPost, Route("GetData")]
        public ActionResult GetData()
        {
            try
            {
                List<Repair> repairList = new List<Repair>();
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                repairList = _unitOfWork.Repair.GetAll().ToList();

                stopwatch.Stop();

                var time = stopwatch.ElapsedMilliseconds;

                return StatusCode(200, "Pobrano rekordy");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Wystąpił błąd: {ex}");
            }
        }
    }
}
