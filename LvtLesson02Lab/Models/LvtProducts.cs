namespace LvtLesson02Lab.Models
{
    public class LvtProducts
    {
        public int LvtId { get; set; }
        public string LvtName { get; set; }
        public string LvtImages { get; set; }
        public decimal LvtPrice { get; set; }
        public decimal? LvtPriceSale { get; set; }
        public int LvtCategoryId { get; set; }
        public string LvtDescription { get; set; }
        public bool LvtStatus { get; set; }
        public DateTime? LvtCreatedAt { get; set; }
    }
}
