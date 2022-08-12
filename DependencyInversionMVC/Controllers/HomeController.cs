using DependencyInversionMVC.Models;
using DependencyInversionMVC.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DependencyInversionMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISchool school;

        public HomeController(ILogger<HomeController> logger,ISchool school)
        {
            _logger = logger;
            this.school = school;
        }

        public IActionResult Index()
        {
            school.Listen();
            school.Learn();
            return View();
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