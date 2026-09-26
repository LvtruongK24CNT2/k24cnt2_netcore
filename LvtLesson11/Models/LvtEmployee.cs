using System;
using System.Collections.Generic;

namespace LvtLesson11.Models;

public partial class LvtEmployee
{
    public long Id { get; set; }

    public string LvtName { get; set; } = null!;

    public string? LvtGender { get; set; }

    public DateOnly? LvtBirthDay { get; set; }

    public string? LvtEmail { get; set; }

    public string? LvtPhone { get; set; }

    public bool LvtActive { get; set; }
}
