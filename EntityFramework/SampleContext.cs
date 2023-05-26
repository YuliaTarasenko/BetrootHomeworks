using Azure;
using EntityFramework.Models;
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
                HasMany(o => o.Orders).
                WithOne(c => c.Customer).
                HasForeignKey(c => c.CustomerId).
                IsRequired();
            builder.Entity<Employee>().
                HasMany(o => o.Orders).
                WithOne(c => c.Employee).
                HasForeignKey(c => c.EmployeeId).
                IsRequired();
            builder.Entity<Order>().
                HasMany(o => o.Products).
                WithMany(p => p.Orders).
                UsingEntity<OrderProduct>(
                l => l.HasOne(op => op.Product).WithMany().
                HasForeignKey(op => op.ProductId),
                r => r.HasOne(op => op.Order).WithMany().
                HasForeignKey(op => op.OrderId),
                t => t.HasKey(op => new{op.ProductId, op.OrderId}));
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            "Data Source=LAPTOP-47TRIN9C\\MSSQLSERVER01;" + "Initial Catalog=Shop;"
            + "Integrated Security=True;" + "TrustServerCertificate = True");
    }
}
