using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public Engine Engine { get; set; }
        public Wheel Wheel { get; set; }    
        public BaseCharacteristics BaseCharacteristics { get; set; }
        public Vehicle() { }

        public Vehicle(string brand, Engine engine, Wheel wheel, BaseCharacteristics baseCharacteristics)
        {
            Brand = brand;
            Engine = engine;
            Wheel = wheel;
            BaseCharacteristics = baseCharacteristics;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine(Brand);
        }
    }
}
