using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShop.Interfaces
{
    internal interface ICustomer
    {
        int CustomerId { get; set; }
        List<Order> OrderList { get; set; }
        string GetCustomerDetails();
    }
}
