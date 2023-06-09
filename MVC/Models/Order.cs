using Microsoft.EntityFrameworkCore;
using MVC.Logic;
using static NuGet.Packaging.PackagingConstants;

namespace MVC.Models
{
    public record Order
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
