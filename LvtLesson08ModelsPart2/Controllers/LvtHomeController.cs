using LvtLesson08ModelsPart2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LvtLesson08ModelsPart2.Controllers
{
    public class LvtHomeController : Controller
    {
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
