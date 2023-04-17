using InternetShop.Classes;

namespace InternetShop
{
    internal class Order: IOrder
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public Cashier Cashier { get; set; }
        public Order (int  orderId, Customer customer, DateTime orderDate,Cashier cashier)
        {
            OrderId = orderId;
            Customer = customer;
            OrderDate = orderDate;
            Cashier = cashier;
            OrderItems = new List<OrderItem> ();
        }

        public List<OrderItem> AddItems(Product product, int quantity)
        {
            var item = new OrderItem(product, quantity);
            OrderItems.Add(item);
            return OrderItems;
        }

        public void RemoveItems(OrderItem item)
        {
            OrderItems.Remove(item);
        }
        public double CalculateTotalAmount()
        {
            TotalAmount = 0;
            foreach(OrderItem item in OrderItems)
            {
                TotalAmount += item.Quantity * item.Product.Price;
            }
            return TotalAmount;
        }
    }
}
