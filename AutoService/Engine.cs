using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Engine
    {
        public int CylinderCount { get; set; }
        public double Displacement { get; set; }
        public Fuel Fuel { get; set; }
        public Engine(int cylinderCount, double displacement, Fuel fuel) 
        {
            CylinderCount = cylinderCount;
            Displacement = displacement;
            Fuel = fuel;
        }

        public void Info()
        {
            Console.WriteLine($"Type of engine:\nCylinder count = {CylinderCount},\n" +
                $"Displacement = {Displacement},\nFuel is {Fuel}");
        }
    }
}
