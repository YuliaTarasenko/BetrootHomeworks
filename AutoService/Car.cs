using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    internal class Car : Vehicle
    {
        public string Model { get; set; }
        public Trunk Trunk { get; set; }
        public Car(string brand, string model, Engine engine, Wheel wheel, BaseCharacteristics baseCharacteristics, Trunk trunk)
            :base(brand, engine, wheel, baseCharacteristics)
        {
            Model = model;
            Trunk = trunk;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(Model);
            Engine.Info();
            Wheel.Info();
            Trunk.Info();
        }

    }
}
