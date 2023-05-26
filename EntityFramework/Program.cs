using EntityFramework;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

//CustomersCount();
//var customers = GetAllCustomers();
//AddCustomer();
//DeleteCustomer(51);
//UpdateCustomer(2);
//GetRelaredData();
CreateOrderWithDetails()
Console.WriteLine();

void CreateOrderWithDetails()
{
    using var context = new SampleContext();
    var newOrder = new Order(1, 1, 1, 1, DateTime.Now);
    context.Orders.Add(newOrder);
    context.SaveChanges();
    var orderWithDetails = context.Orders.
        FirstOrDefault(o => o.Id == 1); 
    Console.WriteLine();
}

void GetRelaredData()
{
    using var context = new SampleContext();
        var orders = context.Orders.
        Include(order => order.Customer).
        Where(o=>o.OrdersProducts !=null).
        ToArray();
    Console.WriteLine();
}

void UpdateCustomer(int id)
{
    using var context = new SampleContext();
    var customer = context.Customers.FirstOrDefault(customer => customer.CustomerId == id);
    if (customer is null) return;
    customer.FirstName = "John";
    context.SaveChanges();
}

void DeleteCustomer(int id)
{
    using var context = new SampleContext();
    var customer = context.Customers.FirstOrDefault(customer=>customer.CustomerId==id);
    if(customer is null) return;
    context.Customers.Remove(customer);
    context.SaveChanges();
}
void AddCustomer()
{
    var customer = new Customer()
    {
        CustomerId = 51,
        FirstName = "Alice",
        Lastname = "Smith",
        Age = 19,
        Address = "Some address",
        Gender = "Female"
    };
    using var context = new SampleContext();
    context.Customers.Add(customer);
    context.SaveChanges();
}
List<Customer> GetAllCustomers()
{
    using var context = new SampleContext();
    return context.Customers.ToList();
}

void CustomersCount()
{
    using var context = new SampleContext();
    var count = context.Customers.Count();
    Console.WriteLine();
}
//internal class Program
//{
//    static void Main(string[] args)
//    {
        
//    }
//}