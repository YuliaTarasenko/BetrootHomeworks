using Azure;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public sealed class SampleContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Customer>().
                HasMany(o=>o.Order).
                WithOne(c=>c.Customer).
                HasForeignKey(c=>c.CustomerId).
                IsRequired();
            builder.Entity<Employee>().
                HasMany(o => o.Order).
                WithOne(c => c.Employee).
                HasForeignKey(c => c.EmployeeId).
                IsRequired();
            builder.Entity<Product>().
                HasMany(o => o.Order).
                WithMany(p => p.Product).
                UsingEntity<OrderProduct>(
                l => l.HasOne<Order>().WithMany().HasForeignKey(e => e.OrderId),
                r => r.HasOne<Product>().WithMany().HasForeignKey(e => e.ProductId));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            "Data Source=LAPTOP-47TRIN9C\\MSSQLSERVER01;" + "Initial Catalog=Shopdb;"
            + "Integrated Security=True;" + "TrustServerCertificate = True");
    }
}
