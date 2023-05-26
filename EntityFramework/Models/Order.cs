namespace EntityFramework.Models
{
    public sealed record Order : EntityWithId
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public List<Product> Product { get; set; } 
        public List<OrderProduct> OrdersProducts { get; set; } 
        public Order()
        {

        }

        public Order(int id, int productId, int customerId, int employeeId, DateTime orderDate)
        {
            Id = id;
            ProductId = productId;
            CustomerId = customerId;
            EmployeeId = employeeId;
            OrderDate = orderDate;
        }
    }
}
