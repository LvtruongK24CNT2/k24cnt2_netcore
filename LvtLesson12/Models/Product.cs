using System;
using System.Collections.Generic;

namespace LvtLesson12.Models;

public partial class Product
{
    public string LvtId { get; set; } = null!;

    public string LvtName { get; set; } = null!;

    public decimal LvtPrice { get; set; }

    public decimal? LvtSalePrice { get; set; }

    public string LvtStatus { get; set; } = null!;

    public DateTime LvtCreateDate { get; set; }

    public string? LvtImages { get; set; }

    public string? LvtCategoryId { get; set; }

    public string? LvtDescription { get; set; }
}
