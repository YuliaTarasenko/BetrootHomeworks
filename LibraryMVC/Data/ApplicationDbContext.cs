using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using LibraryMVC.Models;

namespace LibraryMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<LibraryMVC.Models.Book> Book { get; set; } = default!;
        public DbSet<LibraryMVC.Models.Author> Author { get; set; } = default!;
        public DbSet<LibraryMVC.Models.Customer> Customer { get; set; } = default!;
        public DbSet<LibraryMVC.Models.Order> Order { get; set; } = default!;
    }
}