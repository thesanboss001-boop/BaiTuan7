using Microsoft.EntityFrameworkCore;

namespace QuanLySinhVien.DAL;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // SQL Server LocalDB (đi kèm Visual Studio). Đổi chuỗi kết nối nếu dùng SQL Server khác.
        optionsBuilder.UseSqlServer(
            @"Server=LAPTOP-NKERB81T\SQLEXPRESS;Database=QuanLySinhVienDB;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
