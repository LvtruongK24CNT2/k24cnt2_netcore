using Microsoft.AspNetCore.Mvc;
using LvtLesson08ModelsPart2.Models;

namespace LvtLesson08ModelsPart2.Controllers
{
    public class LvtMemberController : Controller
    {
        // mock data
        private static List<LvtMember> _lvtMembers = new List<LvtMember>()
        {
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "lvt_admin",
                LvtPassWord = "123456Password@",
                LvtFullName = "Lê Văn Tưởng",
                LvtEmail = "vantuong.admin@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "lvt_user01",
                LvtPassWord = "UserPass123!",
                LvtFullName = "Trần Thị Ánh",
                LvtEmail = "anh.tran@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "lvt_customer",
                LvtPassWord = "CustomerPass2026!",
                LvtFullName = "Nguyễn Văn Hùng",
                LvtEmail = "hung.nguyen@yahoo.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "lvt_seller",
                LvtPassWord = "SellerPass#456",
                LvtFullName = "Lê Hoàng Nam",
                LvtEmail = "nam.le@hotmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUserName = "lvt_member05",
                LvtPassWord = "MemberPass$789",
                LvtFullName = "Đặng Thị Mai",
                LvtEmail = "mai.dang@gmail.com"
            }
        };

        // GET: Danh sách thành viên
        public IActionResult LvtIndex()
        {
            return View(_lvtMembers);
        }

        [HttpGet]
        public IActionResult LvtCreate()
        {
            var member = new LvtMember();
            return View(member);
        }

        [HttpPost]
        public IActionResult LvtCreate(LvtMember lvtMember)
        {
            lvtMember.LvtMemberId = Guid.NewGuid().ToString();
            _lvtMembers.Add(lvtMember);
            return RedirectToAction("LvtIndex");
        }

        [HttpGet]
        public IActionResult LvtEdit(string id)
        {
            var member = _lvtMembers.FirstOrDefault(x => x.LvtMemberId.Equals(id));
            return View(member);
        }

        [HttpPost]
        public IActionResult LvtEdit(string id, LvtMember lvtMember)
        {
            for (int i = 0; i < _lvtMembers.Count; i++)
            {
                if (_lvtMembers[i].LvtMemberId == id)
                {
                    _lvtMembers[i].LvtUserName = lvtMember.LvtUserName;
                    _lvtMembers[i].LvtPassWord = lvtMember.LvtPassWord;
                    _lvtMembers[i].LvtFullName = lvtMember.LvtFullName;
                    _lvtMembers[i].LvtEmail = lvtMember.LvtEmail;
                    return RedirectToAction("LvtIndex");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult LvtDetails(string id)
        {
            var member = _lvtMembers.FirstOrDefault(x => x.LvtMemberId.Equals(id));
            return View(member);
        }

        [HttpGet]
        public IActionResult LvtDelete(string id)
        {
            var member = _lvtMembers.FirstOrDefault(x => x.LvtMemberId.Equals(id));
            return View(member);
        }

        [HttpPost]
        public IActionResult LvtDeleted(string id)
        {
            foreach (var item in _lvtMembers)
            {
                if (item.LvtMemberId.Equals(id))
                {
                    _lvtMembers.Remove(item);
                    return RedirectToAction("LvtIndex");
                }
            }
            return RedirectToAction("LvtIndex");
        }
    }
}