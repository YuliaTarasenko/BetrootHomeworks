﻿using System;
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
        List<OrderItem> OrderItems { get; set; }
        DateTime OrderDate { get; set; }
        double TotalAmount { get; set; }

       void AddItems(OrderItem item);
       void RemoveItems(OrderItem item);
    }
}
