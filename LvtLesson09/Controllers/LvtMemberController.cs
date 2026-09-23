using LvtLesson09.Models.DataModels;
using LvtLesson09.Models.DataViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LvtLesson09.Controllers
{
    public class LvtMemberController : Controller
    {
        private static List<LvtMember> _lvtMember = new List<LvtMember>();
        // GET: LvtMemberController
        public ActionResult Index()
        {
            return View();
        }

        // GET: LvtMemberController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LvtMemberController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LvtMemberController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LvtMemberRegister LvtMember)
        {
            try
            {

                if (!ModelState.IsValid)
                {
                    return View(LvtMember);
                }

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Có lỗi xảy ra: " + ex.Message);
                return View(LvtMember);
            }
        }

        // GET: LvtMemberController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LvtMemberController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LvtMemberController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LvtMemberController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
