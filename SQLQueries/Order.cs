﻿namespace SQLQueries
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int BookId { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
        public Order() { }
    }
}
