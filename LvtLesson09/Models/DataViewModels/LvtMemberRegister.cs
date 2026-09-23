using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LvtLesson09.Models.DataViewModels
{
    public class LvtMemberRegister
    {
        public int LvtMemberId { get; set; }

        [DisplayName("Ten dang nhap")]
        [Required(ErrorMessage = "Ten dang nhap khong de trong")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tên đăng nhập có độ dài trong khoản 2 - 20 ký tự")]
        public string LvtUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string LvtPassword { get; set; }

        public string LvtEmail { get; set; }

        public string LvtPhoneNumber { get; set; }

        public string LvtFullName { get; set; }

        public string LvtBirthday { get; set; }
    }
}
