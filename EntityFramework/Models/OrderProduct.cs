using EntityFramework.Models;

public sealed record OrderProduct
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public Product Product { get; set; } 
    public Order Order { get; set; }
}
