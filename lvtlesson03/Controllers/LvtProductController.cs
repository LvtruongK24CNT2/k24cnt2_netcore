using lvtlesson03.Models;
using Microsoft.AspNetCore.Mvc;

namespace lvtlesson03.Controllers
{
    [Route("/danh-sach-san-pham")]
    public class LvtProductController : Controller
    {
        // Mock data
        private readonly List<LvtProduct> _products = new()
        {
            new LvtProduct
            {
                LvtProductID = "MB-001",
                LvtProductName = "iPhone 15 Pro Max",
                LvtYearRelease = 2023,
                LvtPrice = 29990000
            },
            new LvtProduct
            {
                LvtProductID = "MB-002",
                LvtProductName = "Samsung Galaxy S24 Ultra",
                LvtYearRelease = 2024,
                LvtPrice = 31990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-003",
                LvtProductName = "Xiaomi 14 Ultra",
                LvtYearRelease = 2024,
                LvtPrice = 27990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-004",
                LvtProductName = "Google Pixel 8 Pro",
                LvtYearRelease = 2023,
                LvtPrice = 22500000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-005",
                LvtProductName = "OPPO Find N3 Flip",
                LvtYearRelease = 2023,
                LvtPrice = 19990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-006",
                LvtProductName = "ASUS ROG Phone 8 Pro",
                LvtYearRelease = 2024,
                LvtPrice = 28990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-007",
                LvtProductName = "Samsung Galaxy Z Fold5",
                LvtYearRelease = 2023,
                LvtPrice = 34990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-008",
                LvtProductName = "iPhone 13",
                LvtYearRelease = 2021,
                LvtPrice = 13990000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-009",
                LvtProductName = "Xiaomi Redmi Note 13 Pro",
                LvtYearRelease = 2024,
                LvtPrice = 7290000m
            },
            new LvtProduct
            {
                LvtProductID = "MB-010",
                LvtProductName = "Realme 12 Pro+",
                LvtYearRelease = 2024,
                LvtPrice = 9990000m
            }
        };

        public IActionResult Index()
        {
            return Json(_products);
        }
        // Collection => view
        [Route("all")]     
        public IActionResult LvtGetAllProduct()
        {
            ViewData["products"] = _products;
            return View();
        }
    }
}
