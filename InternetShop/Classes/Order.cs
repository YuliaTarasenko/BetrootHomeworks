namespace InternetShop
{
    internal class Order: IOrder
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public Order (int  orderId, Customer customer, List<OrderItem> orderItems, DateTime orderDate)
        {
            OrderId = orderId;
            Customer = customer;
            OrderItems = orderItems;
            OrderDate = orderDate;

            TotalAmount = CalculateTotalAmount();
        }

        public void AddItems(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItems(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        private double CalculateTotalAmount()
        {
            double total = 0;
            foreach(OrderItem item in OrderItems)
            {
                total += item.Quantity * item.Product.Price;
            }
            return total;
        }
    }
}
