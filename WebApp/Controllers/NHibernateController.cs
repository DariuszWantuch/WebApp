using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApp.Data.NH.Repository;
using WebApp.Data.NH.Repository.IRepository;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NHibernateController : Controller
    {
        private readonly AppService _appService;
        private readonly INHUnitOfWork _unitOfWork;

        public NHibernateController(AppService appService, INHUnitOfWork unitOfWork)
        {
            _appService = appService;
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
                Stopwatch stopwatch = new Stopwatch();

                stopwatch.Start();

                for (int i = 0; i < 5000; i++)
                {
                    var repair = _appService.GetRepair();

                    _unitOfWork.Repair.Add(repair);
                }

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
