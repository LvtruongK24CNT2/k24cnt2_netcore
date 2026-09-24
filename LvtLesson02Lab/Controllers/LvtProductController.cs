using Microsoft.AspNetCore.Mvc;
using LvtLesson02Lab.Models;

namespace LvtLesson02Lab.Controllers
{
    public class LvtProductController : Controller
    {
        public IActionResult Index()
        {
            List<LvtProducts> lvtProducts = new List<LvtProducts>
            {
                new LvtProducts
                {
                    LvtId = 1,
                    LvtName = "Bộ đồ bơi cho trẻ em nam",
                    LvtImages = "/images/1.jpg",
                    LvtPrice = 50000m,
                    LvtPriceSale = 35000m,
                    LvtCategoryId = 1,
                    LvtDescription = "Bộ đồ bơi dành cho trẻ em nam, chất liệu co giãn 4 chiều thoải mái.",
                    LvtStatus = true,
                    LvtCreatedAt = DateTime.Now
                },
                new LvtProducts
                {
                    LvtId = 2,
                    LvtName = "Bộ đồ bơi cho trẻ em nữ",
                    LvtImages = "/images/2.jpg",
                    LvtPrice = 50000m,
                    LvtPriceSale = 35000m,
                    LvtCategoryId = 1,
                    LvtDescription = "Bộ đồ bơi nữ cho bé, thiết kế dễ thương, chất vải nhanh khô.",
                    LvtStatus = true,
                    LvtCreatedAt = DateTime.Now
                },
                new LvtProducts
                {
                    LvtId = 3,
                    LvtName = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi",
                    LvtImages = "/images/3.jpg",
                    LvtPrice = 50000m,
                    LvtPriceSale = 35000m,
                    LvtCategoryId = 1,
                    LvtDescription = "Size chuẩn cho các bé từ 3 đến 5 tuổi, bảo vệ da bé chống tia UV.",
                    LvtStatus = true,
                    LvtCreatedAt = DateTime.Now
                },
                new LvtProducts
                {
                    LvtId = 4,
                    LvtName = "Bộ đồ bơi cho trẻ em thời trang",
                    LvtImages = "/images/4.jpg",
                    LvtPrice = 50000m,
                    LvtPriceSale = 35000m,
                    LvtCategoryId = 1,
                    LvtDescription = "Mẫu đồ bơi thời trang mới nhất, phối màu bắt mắt.",
                    LvtStatus = true,
                    LvtCreatedAt = DateTime.Now
                },
                new LvtProducts
                {
                    LvtId = 5,
                    LvtName = "Túi thời trang mẫu mới 2021",
                    LvtImages = "/images/5.jpg",
                    LvtPrice = 50000m,
                    LvtPriceSale = 35000m,
                    LvtCategoryId = 2,
                    LvtDescription = "Túi xách thời trang cao cấp, kiểu dáng trẻ trung năng động.",
                    LvtStatus = true,
                    LvtCreatedAt = DateTime.Now
                }
            };

            return View(lvtProducts);
        }

        public IActionResult Details(int id)
        {
            List<LvtProducts> lvtProducts = new List<LvtProducts>
            {
                new LvtProducts { LvtId = 1, LvtName = "Bộ đồ bơi cho trẻ em nam", LvtImages = "/images/1.jpg", LvtPrice = 50000m, LvtPriceSale = 35000m, LvtCategoryId = 1, LvtDescription = "Bộ đồ bơi dành cho trẻ em nam, chất liệu co giãn 4 chiều thoải mái.", LvtStatus = true, LvtCreatedAt = DateTime.Now },
                new LvtProducts { LvtId = 2, LvtName = "Bộ đồ bơi cho trẻ em nữ", LvtImages = "/images/2.jpg", LvtPrice = 50000m, LvtPriceSale = 35000m, LvtCategoryId = 1, LvtDescription = "Bộ đồ bơi nữ cho bé, thiết kế dễ thương, chất vải nhanh khô.", LvtStatus = true, LvtCreatedAt = DateTime.Now },
                new LvtProducts { LvtId = 3, LvtName = "Bộ đồ bơi cho trẻ em từ 3-5 tuổi", LvtImages = "/images/3.jpg", LvtPrice = 50000m, LvtPriceSale = 35000m, LvtCategoryId = 1, LvtDescription = "Size chuẩn cho các bé từ 3 đến 5 tuổi, bảo vệ da bé chống tia UV.", LvtStatus = true, LvtCreatedAt = DateTime.Now },
                new LvtProducts { LvtId = 4, LvtName = "Bộ đồ bơi cho trẻ em thời trang", LvtImages = "/images/4.jpg", LvtPrice = 50000m, LvtPriceSale = 35000m, LvtCategoryId = 1, LvtDescription = "Mẫu đồ bơi thời trang mới nhất, phối màu bắt mắt.", LvtStatus = true, LvtCreatedAt = DateTime.Now },
                new LvtProducts { LvtId = 5, LvtName = "Túi thời trang mẫu mới 2021", LvtImages = "/images/5.jpg", LvtPrice = 50000m, LvtPriceSale = 35000m, LvtCategoryId = 2, LvtDescription = "Túi xách thời trang cao cấp, kiểu dáng trẻ trung năng động.", LvtStatus = true, LvtCreatedAt = DateTime.Now }
            };

            var product = lvtProducts.FirstOrDefault(p => p.LvtId == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
