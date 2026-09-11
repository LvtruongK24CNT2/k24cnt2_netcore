using LvtNetCoreMVCLab03.Models;
using Microsoft.AspNetCore.Mvc;

namespace LvtNetCoreMVCLab03.Controllers
{
    public class LvtBookController : Controller
    {
        protected LvtBook book = new LvtBook();
        public IActionResult Index()
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var model = new 
                LvtBook();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            ViewBag.athors = book.Authors;
            ViewBag.genres = book.Genres;
            var model = book.GetPmqBookById(id);
            return View(model);
        }
        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}
