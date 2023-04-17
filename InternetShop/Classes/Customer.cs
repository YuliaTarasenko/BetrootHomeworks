using System.Numerics;
using System.Xml.Linq;

namespace InternetShop
{
    internal class Customer:Person, ICustomer
    {   
        public int CustomerId { get; set; }
        public List<Order> OrderList { get; set; }

        public Customer(int customerId, int personId, string firstname, string lastname, int age, string email,
            string phoneNumber, string address) :
            base(personId, firstname, lastname, age, email, phoneNumber, address)
        {
            CustomerId = customerId;
            OrderList = new List<Order>();
        }

        public void AddNewOrder(Order order)
        {
            if(OrderList.Any(o=> o.OrderId ==order.OrderId))
            {
                Console.WriteLine("This order is already exict");
            }
            else
            {
                OrderList.Add(order);
            }
        }

        public void RemoveOrder(Order order)
        {
            OrderList.Remove(order);
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = OrderList.FirstOrDefault(o => o.OrderId == order.OrderId);
            if (existingOrder != null)
            {
                existingOrder = order;
            }
        }

        public string GetCustomerDetails()
        {
            string details = $"Customer ID: {CustomerId}\nName: {FirstName} {LastName}\nEmail: {Email}\nPhone: {PhoneNumber}";
            return details;
        }

        public string GetCustomerOrders()
        {
            string orders = $"{OrderList}";
            return orders;
        }
    }
}
