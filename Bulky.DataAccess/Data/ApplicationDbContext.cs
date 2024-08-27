using BulkyBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyBook.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Kỹ Năng sống", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Ngoại ngữ", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Thiếu nhi", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Giải pháp công nghệ", StreetAddress="Lâm Văn Bền", City="Thành phố Hồ Chí Minh",
                                PostalCode="70000", State="Việt Nam", PhoneNumber="0123456789"},
                new Company {
                    Id = 2,
                    Name = "Nhà sách Fahasa",
                    StreetAddress = "Quận 7",
                    City = "Thành phố Hồ Chí Minh",
                    PostalCode = "07000",
                    State = "Việt Nam",
                    PhoneNumber = "0983456789"
                },
                new Company {
                    Id = 3,
                    Name = "Nhà sách Nguyễn Huệ",
                    StreetAddress = "Quận 1",
                    City = "Thành phố Hồ Chí Minh",
                    PostalCode = "12355",
                    State = "Việt Nam",
                    PhoneNumber = "0912345678"
                }
                );


            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Sống Trọn Vẹn Với Năm Giác Quan",
                    Author = "Gretchen Rubin",
                    Description = "Sống Trọn Vẹn Với Năm Giác Quan - Trân Trọng Từng Khoảnh Khắc, Trải Nghiệm Mỗi Phút Giây Để Thêm Yêu Cuộc Đời\r\n\r\nSau hơn một thập kỷ nghiên cứu về hạnh phúc và bản chất con người , một ngày nọ, khi vừa bước ra từ phòng khám mắt, Gretchen Rubin chợt nhận thấy mình đã bỏ qua một yếu tố then chốt để đạt đến hạnh phúc: năm giác quan",
                    ISBN = "SWD9999001",
                    ListPrice = 143500,
                    CategoryId = 1,
                    StockQuantity = 99
                },
                new Product
                {
                    Id = 2,
                    Title = "128 Mẹo Cải Thiện Năng Lực Cho Người Mới Đi Làm",
                    Author = "SHE",
                    Description = "S H E là nhà sáng lập và điều hành trung tâm cố vấn và phát triển sự nghiệp cho phái nữ SHElikestại Nhật Bản. Cô mở các lớp học trên khoảng 20 lĩnh vực như thiết kế web, hay viết lách, và thu hút tổng cộng 20.000 người tham gia. Thông qua những khóa học kỹ năng và hoạt động cố vấn, SHE đồng hành cùng nữ giới để giúp họ hiện thực hóa phương pháp làm việc theo cách của riêng mình.",
                    ISBN = "CAW777777701",
                    ListPrice = 92500,
                    CategoryId = 1,
                    StockQuantity = 99
                },
                new Product
                {
                    Id = 3,
                    Title = "Hướng Dẫn Sử Dụng Cơn Giận",
                    Author = "Tùng Phi Tòng",
                    Description = "Tức giận là tiếng gọi của khát vọng\r\n\r\nKhông cần nuốt giận, bạn có quyền “nóng giận khôn ngoan”\r\n\r\nNhìn thấu ẩn ức, chuyển hóa cảm xúc tiêu cực\r\n\r\nChìa khóa vàng “bảng phân tích cơn giận” ",
                    ISBN = "RITO5555501",
                    ListPrice = 109500,
                    CategoryId = 1,
                    StockQuantity = 99
                },
                new Product
                {
                    Id = 4,
                    Title = "Tsunagu Nihongo - Tiếng Nhật Kết Nối - Sơ Cấp 2",
                    Author = "Tsuji Kazuko  \r\nKatsura Miho  \r\nKojima Minako  ",
                    Description = "Cách học được tổ chức theo hình thức đặc biệt ưu tiên việc \"Giao tiếp\" hơn là \"Hiểu\" từ vựng và ngữ pháp. \r\n[Hội thoại tình huống -> Xác nhận mẫu câu -> Luyện tập mẫu câu -> Hội thoại ứng dụng]",
                    ISBN = "WS3333333301",
                    ListPrice = 212500,
                    CategoryId = 2,
                    StockQuantity = 99
                },
                new Product
                {
                    Id = 5,
                    Title = "Perfect Ielts Vocabulary - Bí Kiếp Chinh Phục 4 Kỹ Năng Trong Kỳ Thi IELTS",
                    Author = "William Jang",
                    Description = "Perfect IELTS Vocabulary hội tụ đầy đủ các yếu tố mà một người học IELTS, đặc biệt là những người tự học đang tìm kiếm. Cuốn sách trang bị cho người học lượng từ vựng cực “khủng” (chỉ với hơn 200 nghìn với một cuốn sách 600 trang) sử dụng cho cả bốn kỹ năng Nghe, Nói, Đọc, Viết trong kỳ thi IELTS",
                    ISBN = "SOTJ1111111101",
                    ListPrice = 220000,
                    CategoryId = 2,
                    StockQuantity = 99
                },
                new Product
                {
                    Id = 6,
                    Title = "150++ Nghề Nghiệp Cho Tương Lai",
                    Author = "Thu Trang",
                    Description = "Udating...",
                    ISBN = "FOT000000001",
                    ListPrice = 106000,
                    CategoryId = 3,
                    StockQuantity = 99
                }
                );
        }
    }
}
