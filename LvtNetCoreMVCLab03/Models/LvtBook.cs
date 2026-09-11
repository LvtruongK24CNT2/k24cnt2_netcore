using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LvtNetCoreMVCLab03.Models
{
    public class LvtBook
    {
        public int LvtId { get; set; }
        public string LvtTitle { get; set; }
        public int LvtAuthorID { get; set; }
        public int LvtGenreId { get; set; }
        public string LvtImages { get; set; }
        public float LvtPrice { get; set; }
        public int LvtTotalPage { get; set; }
        public string LvtSumary { get; set; }

        public List<LvtBook> GetBookList()
        {
            List<LvtBook> books = new List<LvtBook>()
            {
                new()
                {
                    LvtId = 1,
                    LvtTitle = "Dế Mèn Phiêu Lưu Ký",
                    LvtAuthorID = 1,
                    LvtGenreId = 1,
                    LvtImages = "/images/1.jpg",
                    LvtPrice = 65000f,
                    LvtTotalPage = 188,
                    LvtSumary = "Tác phẩm văn học thiếu nhi kinh điển kể về cuộc phiêu lưu tự do và bài học trưởng thành của Dế Mèn."
                },
                new()
                {
                    LvtId = 2,
                    LvtTitle = "Tôi Thấy Hoa Vàng Trên Cỏ Xanh",
                    LvtAuthorID = 2,
                    LvtGenreId = 2,
                    LvtImages = "/images/2.jpg",
                    LvtPrice = 110000f,
                    LvtTotalPage = 378,
                    LvtSumary = "Câu chuyện tuổi thơ êm đềm nhưng đầy xao xuyến ở một làng quê Việt Nam nghèo khó."
                },
                new()
                {
                    LvtId = 3,
                    LvtTitle = "Đắc Nhân Tâm",
                    LvtAuthorID = 3,
                    LvtGenreId = 3,
                    LvtImages = "/images/3.jpg",
                    LvtPrice = 98000f,
                    LvtTotalPage = 320,
                    LvtSumary = "Cuốn sách nghệ thuật ứng xử và thu phục lòng người bán chạy nhất mọi thời đại."
                },
                new()
                {
                    LvtId = 4,
                    LvtTitle = "Nhà Giả Kim",
                    LvtAuthorID = 4,
                    LvtGenreId = 4,
                    LvtImages = "/images/4.jpg",
                    LvtPrice = 79000f,
                    LvtTotalPage = 228,
                    LvtSumary = "Hành trình theo đuổi vận mệnh và ước mơ của chàng chăn cừu Santiago."
                },
                new()
                {
                    LvtId = 5,
                    LvtTitle = "Số Đỏ",
                    LvtAuthorID = 5,
                    LvtGenreId = 5,
                    LvtImages = "/images/5.jpg",
                    LvtPrice = 72000f,
                    LvtTotalPage = 270,
                    LvtSumary = "Tiểu thuyết trào phúng đả kích sâu sắc xã hội Âu hóa nửa mùa thời kỳ Pháp thuộc."
                },
                new()
                {
                    LvtId = 6,
                    LvtTitle = "Cây Cam Ngọt Của Tôi",
                    LvtAuthorID = 6,
                    LvtGenreId = 2,
                    LvtImages = "/images/6.jpg",
                    LvtPrice = 108000f,
                    LvtTotalPage = 244,
                    LvtSumary = "Câu chuyện rung động lòng người về cậu bé Zezé và tình yêu thương trong nghèo khó."
                },
                new()
                {
                    LvtId = 7,
                    LvtTitle = "Tuổi Trẻ Đáng Giá Bao Nhiêu?",
                    LvtAuthorID = 7,
                    LvtGenreId = 3,
                    LvtImages = "/images/7.jpg",
                    LvtPrice = 85000f,
                    LvtTotalPage = 292,
                    LvtSumary = "Cuốn sách truyền cảm hứng sống, học tập và trải nghiệm cho người trẻ."
                },
                new()
                {
                    LvtId = 8,
                    LvtTitle = "Tắt Đèn",
                    LvtAuthorID = 8,
                    LvtGenreId = 5,
                    LvtImages = "/images/8.jpg",
                    LvtPrice = 55000f,
                    LvtTotalPage = 216,
                    LvtSumary = "Tác phẩm hiện thực chấn động về số phận bế tắc của nông dân Việt Nam trước năm 1945."
                },
                new()
                {
                    LvtId = 9,
                    LvtTitle = "Rừng Na Uy",
                    LvtAuthorID = 9,
                    LvtGenreId = 4,
                    LvtImages = "/images/9.jpg",
                    LvtPrice = 135000f,
                    LvtTotalPage = 550,
                    LvtSumary = "Tiểu thuyết về ký ức, tình yêu và những mất mát tuổi trẻ tại Nhật Bản thập niên 1960."
                },
                new()
                {
                    LvtId = 10,
                    LvtTitle = "Mắt Biếc",
                    LvtAuthorID = 2,
                    LvtGenreId = 2,
                    LvtImages = "/images/10.jpg",
                    LvtPrice = 115000f,
                    LvtTotalPage = 300,
                    LvtSumary = "Chuyện tình đơn phương si tình và đượm buồn của Ngạn dành cho Hà Lan."
                }
            };
            return books;
        }
        public LvtBook? GetPmqBookById(int id)
        {
            return GetBookList().FirstOrDefault(b => b.LvtId == id);
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Tô Hoài" },
            new SelectListItem { Value = "2", Text = "Nguyễn Nhật Ánh" },
            new SelectListItem { Value = "3", Text = "Dale Carnegie" },
            new SelectListItem { Value = "4", Text = "Paulo Coelho" },
            new SelectListItem { Value = "5", Text = "Vũ Trọng Phụng" },
            new SelectListItem { Value = "6", Text = "José Mauro de Vasconcelos" },
            new SelectListItem { Value = "7", Text = "Rosie Nguyễn" },
            new SelectListItem { Value = "8", Text = "Ngô Tất Tố" },
            new SelectListItem { Value = "9", Text = "Haruki Murakami" }
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>()
        {
            new SelectListItem { Value = "1", Text = "Văn học thiếu nhi" },
            new SelectListItem { Value = "2", Text = "Truyện dài / Tâm lý tuổi học trò" },
            new SelectListItem { Value = "3", Text = "Kỹ năng sống / Đào tạo kỹ năng ứng xử" },
            new SelectListItem { Value = "4", Text = "Tiểu thuyết triết lý nước ngoài" },
            new SelectListItem { Value = "5", Text = "Tiểu thuyết trào phúng hiện thực" },
            new SelectListItem { Value = "6", Text = "Truyện dài / Tâm lý tình cảm gia đình" },
            new SelectListItem { Value = "7", Text = "Kỹ năng sống / Truyền cảm hứng cho giới trẻ" },
            new SelectListItem { Value = "8", Text = "Văn học hiện thực phê phán" },
            new SelectListItem { Value = "9", Text = "Tiểu thuyết lãng mạn - tâm lý nước ngoài" },
            new SelectListItem { Value = "10", Text = "Truyện dài / Tình cảm học đường" }
        };
    }
}
