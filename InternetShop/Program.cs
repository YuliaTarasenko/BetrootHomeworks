using InternetShop.Classes;

namespace InternetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductCatalog catalog = new ProductCatalog();
            Product book = new Product(1, "Book", "For reading", 15.75, 20);
            Product toy = new Product(2, "Toy", "For playing", 40.2, 5);
            Product instrument = new Product(3, "Instrument", "For smth", 154.1, 1);
            instrument.AddQuantity(4);

            catalog.AddProduct(book);
            catalog.AddProduct(toy);
            catalog.AddProduct(instrument);

            Cashier cashier1 = new Cashier(1, "Iton", "Doj", 22, "jfldf@flf.jd");
            Customer customer1 = new Customer(2, "Rebbeka", "Bloom", 18, "njf@jkfj.com", "380252552525", "Kyiv,Sar street 20");
            //List<OrderItem> orderitems = new List<OrderItem>();

            Order order1 = new Order(45, customer1, DateTime.Now, cashier1);
            order1.AddItems(book, 2);
            order1.AddItems(instrument, 2);
            order1.CalculateTotalAmount();

            Receipt receipt = new Receipt(order1, DateTime.Now.AddMinutes(10));
            receipt.PrintReceipt();
        }
    }
}