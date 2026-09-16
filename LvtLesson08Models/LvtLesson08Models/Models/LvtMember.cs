using System.ComponentModel;

namespace LvtLesson08Models.Models
{
    public class LvtMember
    {
        public string LvtMemberId { get; set; }
        public string LvtUserName { get;set; }
        public string LvtPassword { get; set; }

        [DisplayName("Họ và tên")]
        public string LvtFullName { get; set; }
        public string LvtEmail { get; set; }
    }

}
