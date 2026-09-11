using Microsoft.AspNetCore.Mvc;
using LvtNetCoreMVCLab03.Models;

namespace LvtNetCoreMVCLab03.ViewComponents
{
    public class LvtBookViewComponent : ViewComponent
    {
        protected LvtBook book = new LvtBook();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}