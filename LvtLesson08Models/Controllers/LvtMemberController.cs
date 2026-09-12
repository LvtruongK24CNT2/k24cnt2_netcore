using LvtLesson08Models.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace LvtLesson08Models.Controllers
{
    public class LvtMemberController : Controller
    {
        //Mock Data
        protected List<LvtMember> _members = new List<LvtMember>
        {
                         new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "truongtv",
                LvtPassword = "123456",
                LvtFullName = "Lương Văn Trường",
                LvtEmail = "truongluong14092006@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "tranthib",
                LvtPassword = "123456",
                LvtFullName = "Trần Thị B",
                LvtEmail = "tranthib@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "levanc",
                LvtPassword = "123456",
                LvtFullName = "Lê Văn C",
                LvtEmail = "levanc@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "phamthid",
                LvtPassword = "123456",
                LvtFullName = "Phạm Thị D",
                LvtEmail = "phamthid@gmail.com"
            },
            new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "hoangvane",
                LvtPassword = "123456",
                LvtFullName = "Hoàng Văn E",
                LvtEmail = "hoangvane@gmail.com"
            }
        };
        public IActionResult Index()
        {
            return View(_members);
        }
        public IActionResult GetMember()
        {
            var member = new LvtMember
            {
                LvtMemberId = Guid.NewGuid().ToString(),
                LvtUseName = "truongtv",
                LvtPassword = "password123",
                LvtFullName = "Lương Văn Trường",
                LvtEmail = "truongluong14092006@gmail.com"
            };
            //ViewBag.Member = member;
            return View(member);
        }
        //Đưa dữ liệu dạng List ra View
        public IActionResult GetMembers()
        {
            // Lấy từ mock data
            ViewBag.Members = _members;
            return View();
        }
        // Get: Create Member
        public IActionResult Create()
        {
            return View();
        }
    }
}
