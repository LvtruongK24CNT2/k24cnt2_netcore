using LvtLesson06Views.Models;
using Microsoft.AspNetCore.Mvc;

namespace LvtLesson06Views.ViewComponents
{
    public class CategoryViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Category>
            {
                new Category {CategoryId = 1, CategoryName = "Electronics",  status = true},
                new Category {CategoryId = 1, CategoryName = "Books",  status = true},
                new Category {CategoryId = 1, CategoryName = "Clothing",  status = true},
                new Category {CategoryId = 1, CategoryName = "Home & KitChen",  status = true}
            };
            n = n ?? 0;
            var search = categories.Where(x => x.CategoryId >= n).ToList();
            return View(categories);
        }
    }
}
