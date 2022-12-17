using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tp4dotnet.Data;
using tp4dotnet.Models;

namespace tp4dotnet.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;
        private Unit UnitOfWork;
        public HomeController(ILogger<HomeController> logger)
        {
            this.UnitOfWork = new Unit();
            _logger = logger;
        }
        public IActionResult Index()
        {
            UniversityContext universityContext = UniversityContext.Instantiate_UniversityContext();
            List<Student> s = universityContext.Student.ToList();
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