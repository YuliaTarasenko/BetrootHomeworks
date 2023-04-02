using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Trunk
    {
        public double Capacity { get; set; }
        public Trunk(double capacity)
        {
            Capacity = capacity;
        }

        public void Info()
        {
            Console.WriteLine($"Capacity of trunk = {Capacity}");
        }
    }
}
