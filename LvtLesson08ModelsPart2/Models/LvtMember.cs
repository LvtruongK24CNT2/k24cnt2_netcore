using System.ComponentModel;

namespace LvtLesson08ModelsPart2.Models
{
        public class LvtMember
        {
            public String LvtMemberId { get; set; }
            public string LvtUserName { get; set; }
            public string LvtPassWord { get; set; }

            [DisplayName("Họ và tên")]
            public string LvtFullName { get; set; }
            public string LvtEmail { get; set; }
        }
    }
