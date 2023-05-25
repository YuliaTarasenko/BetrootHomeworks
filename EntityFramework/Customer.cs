namespace EntityFramework
{
    public sealed record Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }  
        public int Age { get; set; }
        public string Address { get; set; }
        public ICollection<Order> Order { get; } = new List<Order>();
    }
}
