namespace EntityFramework
{
    public sealed record Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int OrderId { get; set; }
        public List<Order> Order { get; } = new();
        public List<OrderProduct> OrdersProducts { get; } = new();
    }
}
