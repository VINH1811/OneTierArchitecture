using Microsoft.EntityFrameworkCore;

namespace TodoApp
{
    public class AppDbContext : DbContext
    {
        // Khai báo bảng Todos
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Chuỗi kết nối của bạn
                optionsBuilder.UseSqlServer("Server=ANHVINH;Database=LAB1SA;Integrated security=True;TrustServerCertificate=True;");
            }
        }
    }
}