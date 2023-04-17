using System.Numerics;
using System.Xml.Linq;

namespace InternetShop
{
    internal class Customer:Person, ICustomer
    {   
        public List<Order> OrderList { get; set; }
        public string ShippingAddress { get; set; }
        public string PhoneNumber { get; set; }

        public Customer(int id, string firstname, string lastname, int age, string email,
            string phoneNumber, string address) :
            base(id, firstname, lastname, age, email)
        {
            ShippingAddress = address;
            PhoneNumber = phoneNumber;
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
            if (OrderList.Any(o => o.OrderId == order.OrderId))
            {
                OrderList.Remove(order);
            }
            else
            {
                Console.WriteLine("This order is not exict");
            }
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
            string details = $"Customer ID: {Id}\nName: {FirstName} {LastName}\nEmail: {Email}\nPhone: {PhoneNumber}";
            return details;
        }

        public void SaveOrder(Order order)
        {
            OrderList.Add(order);
        }

        public string GetCustomerOrders()
        {
            string orders = $"{OrderList}";
            return orders;
        }
    }
}
