using H4_encryption.Models;
using Hashing.Factories;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace H4_encryption.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHashingFactory hashingFactory;

        public HomeController(ILogger<HomeController> logger, IHashingFactory hashingFactory)
        {
            _logger = logger;
            this.hashingFactory = hashingFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hashing()
        {
            return View(new TestViewModel());
        }

        [HttpPost]
        public IActionResult Hashing()
        {
            return View(new HashingViewModel());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}