namespace SQLQueries
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Order Order { get; set; }
        public Customer() { }
    }
}
