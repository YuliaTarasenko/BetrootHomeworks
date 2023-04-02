using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService
{
    public class Wheel
    {
        public int Diameter { get; set; }
        public int Width { get; set; }
        public string Material { get; set; }

        public Wheel(int diameter, int width,string material) 
        { 
            Diameter = diameter;
            Width = width;
            Material = material;
        }

        public void Info()
        {
            Console.WriteLine($"Parameter of wheels: Diameter = {Diameter}, Width = {Width}, Material = {Material}");
        }
    }
}
