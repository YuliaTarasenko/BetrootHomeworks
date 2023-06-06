namespace LibraryMVC.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
    }
}
