using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LvtLesson08Models.Models;

namespace LvtLesson08Models.Controllers
{
    public class LvtHomeController : Controller
    {
        private readonly ILogger<LvtHomeController> _logger;

        public LvtHomeController(ILogger<LvtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LvtIndex()
        {
            return View();
        }

        public IActionResult LvtPrivacy()
        {
            return View();
        }

        public IActionResult LvtAbout()
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
