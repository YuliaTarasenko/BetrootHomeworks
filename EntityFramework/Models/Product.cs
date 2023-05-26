namespace EntityFramework.Models
{
    public sealed record Product : EntityWithId
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public List<Order> Order { get; set; } 
        public List<OrderProduct> OrdersProducts { get; set; } 
    }
}
