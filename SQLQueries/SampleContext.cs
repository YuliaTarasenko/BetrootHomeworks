using Microsoft.EntityFrameworkCore;

namespace SQLQueries
{
    public sealed class SampleContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            "Data Source=LAPTOP-47TRIN9C\\MSSQLSERVER01;" + "Initial Catalog=Librarydb;" + "Integrated Security=True;" + "TrustServerCertificate = True");
    }
}
