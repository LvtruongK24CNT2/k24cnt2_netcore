using LvtLesson06Views.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LvtLesson06Views.Controllers
{
    public class LvtHomeController : Controller
    {
        private readonly ILogger<LvtHomeController> _logger;
        public LvtHomeController(ILogger<LvtHomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
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
