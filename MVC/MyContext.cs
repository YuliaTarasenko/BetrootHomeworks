using Microsoft.EntityFrameworkCore;
using MVC.Models;

namespace MVC
{
    public class MyContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Order>().HasOne(o => o.User).WithMany(u => u.Orders).HasForeignKey(o => o.UserId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
      optionsBuilder.UseSqlServer(
          "Data Source=LAPTOP-47TRIN9C\\MSSQLSERVER01;" +
          "Initial Catalog=Testdb;" +
          "Integrated Security=True;" +
          "TrustServerCertificate=True");
    }
}
