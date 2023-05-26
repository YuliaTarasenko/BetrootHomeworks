using EntityFramework;
using EntityFramework.Models;
using Microsoft.EntityFrameworkCore;

//CustomersCount();
//var customers = GetAllCustomers();
//AddCustomer();
//DeleteCustomer(51);
//UpdateCustomer(2);
GetRelaredData();
//CreateOrderWithDetails();
GetManyToMany();
Console.WriteLine();


void GetManyToMany()
{
    using var context = new SampleContext();
    var orders = context.Orders
        .Include(order => order.Products)
        .ToArray();
    var products = context.Products
        .Include(product => product.Orders)
        .ToArray();

    var customerProducts = context.Customers
        // include orders
        .Include(customer => customer.Orders)
        // then include products
        .ThenInclude(order => order.Products)
        // first person with orders    
        .Where(customer => customer.Orders
            .Any(order => order.Products.Any()))
        // get products from orders
        .SelectMany(customer => customer.Orders)
        .SelectMany(customer => customer.Products)
        .Distinct()
        .OrderBy(product => product.Id).ToArray();
    Console.WriteLine();
}

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
        ToArray();
    var customersWithOrders = context.Customers.
        Include(c=>c.Orders).
        Where(c=>c.Orders.Count >1).
        ToArray();
    Console.WriteLine();
}

void UpdateCustomer(int id)
{
    using var context = new SampleContext();
    var customer = context.Customers.FirstOrDefault(customer => customer.Id == id);
    if (customer is null) return;
    customer.FirstName = "John";
    context.SaveChanges();
}

void DeleteCustomer(int id)
{
    using var context = new SampleContext();
    var customer = context.Customers.FirstOrDefault(customer=>customer.Id==id);
    if(customer is null) return;
    context.Customers.Remove(customer);
    context.SaveChanges();
}
void AddCustomer()
{
    var customer = new Customer()
    {
        Id = 51,
        FirstName = "Alice",
        Lastname = "Smith"
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