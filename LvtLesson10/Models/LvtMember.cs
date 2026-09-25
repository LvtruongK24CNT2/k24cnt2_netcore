using System;
using System.Collections.Generic;

namespace LvtLesson10.Models;

public partial class LvtMember
{
    public long MemberId { get; set; }

    public string LvtUserName { get; set; } = null!;

    public string LvtPassword { get; set; } = null!;

    public string LvtFullName { get; set; } = null!;

    public string LvtEmail { get; set; } = null!;

    public string? LvtPhone { get; set; }

    public bool? LvtStatus { get; set; }
}
