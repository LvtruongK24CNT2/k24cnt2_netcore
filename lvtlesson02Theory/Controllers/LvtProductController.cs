using lvtlesson02Theory.Models;
using Microsoft.AspNetCore.Mvc;

namespace lvtlesson02Theory.Controllers
{
    public class LvtProductController : Controller
    {
        public IActionResult LvtIndex()
        {
            //Dữ liệu trong đối tượng: ViewBag, viewData, TempData
            ViewBag.Name = "Lương Văn Trường";
            ViewData["productVD"] = "Laptop Dell Vostro";
            TempData["UNI"] = "Trường Đại Học Nguyễn Trãi - NTU";
            return View();
        }
        public IActionResult GetProduct()
        {
            // Tạo mock data product
            LvtProduct lvtProduct = new LvtProduct()
            {
                ProductID = "2410900079",
                ProductName = "Lương Văn Trường",
                YearRelease = 2006,
                Price = 1000
            };

            ViewBag.LvtProduct = lvtProduct;
            ViewData["product"] = lvtProduct;
            return View("Product");
        }
    }
}
