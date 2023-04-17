namespace InternetShop
{
    internal class Receipt
    {
        public IOrder Order { get; set; }
        public DateTime ReceiptDate { get; set; }

        public Receipt(IOrder order, DateTime receiptDate)
        {
            Order = order;
            ReceiptDate = receiptDate;
        }

        public void PrintReceipt()
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("               RECEIPT                 ");
            Console.WriteLine("=======================================");
            Console.WriteLine($"Cashier Name: {Order.Cashier.FirstName} {Order.Cashier.LastName}");
            Console.WriteLine($"Date: {ReceiptDate.ToShortDateString()} Time: {ReceiptDate.ToShortTimeString()}");
            Console.WriteLine($"Order ID: {Order.OrderId}");
            Console.WriteLine($"Customer Name: {Order.Customer.FirstName} {Order.Customer.LastName}");
            Console.WriteLine("=======================================");
            Console.WriteLine("Item               Quantity     Price");
            Console.WriteLine("---------------------------------------");

            foreach (OrderItem item in Order.OrderItems)
            {
                Console.WriteLine($"{item.Product.Name,-22}{item.Quantity,-10}{item.Product.Price} $");
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Total Amount: {Order.TotalAmount} $");
            Console.WriteLine("=======================================");
        }
    }
}
