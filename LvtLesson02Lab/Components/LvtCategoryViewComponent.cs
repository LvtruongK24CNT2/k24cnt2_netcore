using LvtLesson02Lab.Models;
using Microsoft.AspNetCore.Mvc;

namespace LvtLesson02Lab.Components
{
    public class LvtCategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categoris = new List<LvtCategorys>
            {
                new LvtCategorys  { LvtId = 1, LvtName = "Quần Áo" },
                new LvtCategorys  { LvtId = 2, LvtName = "Túi xách" },
                new LvtCategorys  { LvtId = 3, LvtName = "Đồng hồ" },
                new LvtCategorys  { LvtId = 4, LvtName = "Ti vi" },
                new LvtCategorys  { LvtId = 5, LvtName = "Tủ lạnh" },
                new LvtCategorys  { LvtId = 6, LvtName = "Máy bơm" },
                new LvtCategorys  { LvtId = 7, LvtName = "Quạt điện" },
                new LvtCategorys { LvtId = 8, LvtName = "Lò sưởi" }
            };
            return View(categoris);
        }
    }
}
