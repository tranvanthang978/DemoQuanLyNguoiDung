using Microsoft.EntityFrameworkCore;
using QuanlyNguoiDung.Models;

namespace QuanlyNguoiDung.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
