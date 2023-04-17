using InternetShop.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Interfaces
{
    internal interface IOrder
    {
        int OrderId { get; set; }
        Customer Customer { get; set; }
        Cashier Cashier { get; set; }
        List<OrderItem> OrderItems { get; set; }
        double TotalAmount { get; set; }

       List<OrderItem> AddItems(Product product, int quantity);
       void RemoveItems(OrderItem item);
    }
}
