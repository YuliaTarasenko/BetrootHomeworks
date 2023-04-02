using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Order : Customer
    {
        public int OrderID { get; set; }    
        public Order (int orderID, int customerId, string firstName, string lastName, string phoneNumber, Vehicle vehicle, Car car)
            :base(customerId, firstName, lastName, phoneNumber, vehicle, car)
        {
            OrderID = orderID;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"New Order №{OrderID}");
            base.PrintInfo();
        }
    }
}
