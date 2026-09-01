using Lvtlesson04.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace Lvtlesson04.Controllers
{
    public class LvtAccountController : Controller
    {
        private readonly List<LvtAccount> lvtAccounts = new()
        {
            new LvtAccount
            {
                Id = 1, Name = "Hoàng Anh",
                Email = "anh@gmail.com",
                Phone = "0986456789",
                Address = "Hà Nội",
                Avatar = "/images/1.jpg",
                Gender = 1, Bio = "My name is small",
                Birthday = new DateTime(1998, 7, 15)
            },
            new LvtAccount
            {
                Id = 2, Name = "Trần Thanh Tâm",
                Email = "tam.tran@gmail.com",
                Phone = "0912345678",
                Address = "Đà Nẵng",
                Avatar = "/images/2.jpg",
                Gender = 0, Bio = "Lover of books and coffee",
                Birthday = new DateTime(2000, 3, 22)
            },
            new LvtAccount
            {
                Id = 3, Name = "Nguyễn Minh Đức",
                Email = "duc.nguyen@gmail.com",
                Phone = "0978123456",
                Address = "TP. Hồ Chí Minh",
                Avatar = "/images/3.jpg",
                Gender = 1, Bio = "Software developer and tech enthusiast",
                Birthday = new DateTime(1995, 11, 5)
            },
            new LvtAccount
            {
                Id = 4, Name = "Lê Ngọc Bích",
                Email = "bich.le@gmail.com",
                Phone = "0934567890",
                Address = "Hải Phòng",
                Avatar = "/images/4.jpg",
                Gender = 0, Bio = "Passionate about travel and photography",
                Birthday = new DateTime(2002, 9, 18)
            }
        };
        public IActionResult LvtIndex()
        {
            ViewBag.LvtAccounts = lvtAccounts;
            return View();
        }
        [Route("ho-so-cua-toi",Name ="LvtProfile")]
        public IActionResult LvtProfile(int? id)
        {
            LvtAccount lvtAccount = new LvtAccount
            {
                Id = 4,
                Name = "Lê Ngọc Bích",
                Email = "bich.le@gmail.com",
                Phone = "0934567890",
                Address = "Hải Phòng",
                Avatar = "/images/4.jpg",
                Gender = 0,
                Bio = "Passionate about travel and photography",
                Birthday = new DateTime(2002, 9, 18)
            };
            if (id != null )    
                lvtAccount = lvtAccounts.FirstOrDefault(x => x.Id == id);

            ViewBag.LvtAccount = lvtAccount;
            return View();
        }
    }
}
