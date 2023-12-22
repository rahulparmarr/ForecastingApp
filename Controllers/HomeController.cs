using ForecastingApplication.Data;
using ForecastingApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ForecastingApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DbContextClass context;


        public HomeController(ILogger<HomeController> logger, DbContextClass context)
        {
            _logger = logger;
            this.context = context;
        }





        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var data = await context.Forecasts.ToListAsync();
            return View(data);
        }

    


        [HttpGet]
        public IActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddData(ForecastViewModel addRequest)
        {
            var data = new ForecastModel()
            {
                Country = addRequest.Country,
                Gender = addRequest.Gender,
                AgeGroup = addRequest.AgeGroup,
                Year = addRequest.Year,
                Value = addRequest.Value,
            };
            await context.Forecasts.AddAsync(data);
            await context.SaveChangesAsync();
            return RedirectToAction("AddData");
        }




        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}