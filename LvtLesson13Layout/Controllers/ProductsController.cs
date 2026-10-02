using Microsoft.AspNetCore.Mvc;

namespace LvtLesson13Layout.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search(string keyword)
        {
            ViewData["keyword"] = keyword;
            return View();
        } 
        
        public IActionResult Host()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
