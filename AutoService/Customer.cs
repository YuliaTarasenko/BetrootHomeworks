using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Customer : Person
    {
        public int CustomerId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Car Car { get; set; }
        public Customer() { }
        public Customer(int customerId, string firstName, string lastName, string phoneNumber, Vehicle vehicle, Car car)
            : base(firstName, lastName, phoneNumber)
        {
            CustomerId = customerId;
            Vehicle = vehicle;
            Car = car;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Customer - {FirstName} {LastName}, Vehicle - {Vehicle.Brand} {Car.Model}");
        }
    }
}
