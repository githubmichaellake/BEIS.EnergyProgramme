using BEIS.EnergyProgramme.Web.Models;
using BEIS.EnergyProgramme.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BEIS.EnergyProgramme.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IndexService _myService;

        public HomeController(ILogger<HomeController> logger, IndexService myService)
        {
            _logger = logger;
            _myService = myService;
        }

        public IActionResult Index()
        {
            var response = _myService.Execute(new Services.Requests.IndexRequestModel { Name = "Test User" });
            return View(new IndexViewModel
            {
                Message = response.Message
            });

            //cntl+k cntl +d = reformat code

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}