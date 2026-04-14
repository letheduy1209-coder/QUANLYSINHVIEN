using Microsoft.EntityFrameworkCore;
using QuanLySinhVien.Models;

namespace QuanLySinhVien.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Khai báo các bảng sẽ xuất hiện trong SQL
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }
    }
}