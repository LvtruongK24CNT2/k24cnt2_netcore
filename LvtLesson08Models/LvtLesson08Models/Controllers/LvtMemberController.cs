using Microsoft.AspNetCore.Mvc;
using LvtLesson08Models.Models;

namespace LvtLesson08Models.Controllers
{
    public class LvtMemberController : Controller
    {
        // Mock data - LvtMember
        private static List<LvtMember> _members = new List<LvtMember>()
        {
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "ChungTv",
                LvtPassword = "Password123!",
                LvtFullName = "Trịnh Văn Chung",
                LvtEmail = "chungtrinhj@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "tranthib",
                LvtPassword = "SecurePass456#",
                LvtFullName = "Trần Thị B",
                LvtEmail = "tranthib@outlook.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "levanc",
                LvtPassword = "MyPassword789$",
                LvtFullName = "Lê Văn C",
                LvtEmail = "levanc@company.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult Index()
        {
            return View(_members);
        }

        [HttpGet]
        public IActionResult LvtCreate()
        {
            var member = new LvtMember();
            return View(member);
        }
        [HttpPost]
        public IActionResult LvtCreate(LvtMember tvcMember)
        {
            tvcMember.LvtMemberId = Guid.NewGuid().ToString();
            _members.Add(tvcMember);

            return RedirectToAction("Index");
            //return View(tvcMember);
        }

        [HttpGet]
        public IActionResult LvtEdit(string id)
        {
            var member = _members.Where(x=>x.LvtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult LvtEdit(string id, LvtMember tvcMember)
        {
            // var member = _members.Where(x => x.LvtMemberId.Equals(id)).FirstOrDefault();
            for (int i = 0; i < _members.Count; i++)
            {
                if (_members[i].LvtMemberId == id)
                {
                    _members[i].LvtUserName = tvcMember.LvtUserName;
                    _members[i].LvtPassword = tvcMember.LvtPassword;
                    _members[i].LvtFullName= tvcMember.LvtFullName;
                    _members[i].LvtEmail=   tvcMember.LvtEmail;

                    return RedirectToAction("Index");
                }
           
            }
            return View();
        }

        [HttpGet]
        public IActionResult LvtDetails(string id)
        {
            var member = _members.Where(x => x.LvtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpGet]
        public IActionResult LvtDelete(string id)
        {
            var member = _members.Where(x => x.LvtMemberId.Equals(id)).FirstOrDefault();
            return View(member);
        }

        [HttpPost]
        public IActionResult LvtDeleted(string id)
        {
            foreach (var item in _members)
            {
                if (item.LvtMemberId.Equals(id))
                {
                    _members.Remove(item);
                    return RedirectToAction("Index");
                }
            }
            return View("LvtDelete");
        }
    }
}
