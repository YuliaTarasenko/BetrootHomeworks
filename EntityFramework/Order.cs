namespace EntityFramework
{
    public sealed record Order
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<Product> Product { get; } = new();
        public List<OrderProduct> OrdersProducts { get; } = new();

    }

    public sealed record OrderProduct
    {
        public int ProductId { get; set;}
        public int OrderId { get; set; }
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }
}
