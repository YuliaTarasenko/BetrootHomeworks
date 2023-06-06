using TestApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace TestApplication.Logic
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        //public MyContext(DbContextOptions<MyContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(
            "Data Source=LAPTOP-47TRIN9C\\MSSQLSERVER01;" +
            "Initial Catalog=Testdb;" +
            "Integrated Security=True;" + 
            "TrustServerCertificate=True");
    }
}
