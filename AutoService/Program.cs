namespace AutoService
{
    internal class Program
    {

        static void Main(string[] args)
        {
           Vehicle vehicle1 = new Vehicle();
           vehicle1.Brand = "Toyota";
           Engine engine1 = new Engine(4, 2.5, Fuel.gas);
           Trunk trunk1 = new Trunk(3.2); 
           Wheel wheels1 = new Wheel(17, 205, "aluminum");
           BaseCharacteristics characteristics = new BaseCharacteristics();
           characteristics.MileAge = 157354;
           characteristics.ProductionYear = new DateTime(2021,02,01);
           Car car = new Car("Toyota", "Camry", engine1,wheels1,characteristics,trunk1);
           car.DisplayInfo();
           Console.WriteLine();

           Vehicle vehicle2 = new Vehicle();
           vehicle2.Brand = "Ford";
           Engine engine2 = new Engine(4, 2.0, Fuel.diesel);
           Trunk trunk2 = new Trunk(5.6);
           Wheel wheels2 = new Wheel(16, 19, "steel");
           BaseCharacteristics characteristics2 = new BaseCharacteristics();
           characteristics2.Weight = 1865;
           characteristics2.MaxSpeed = 180;
           Truck truck = new Truck("Transit Custom", "Ford", engine2, wheels2, characteristics2, trunk2);
           truck.DisplayInfo();
           Console.WriteLine();

           Person person1 = new Person();
           Customer customer1 = new Customer();
           Order order1 = new Order(1, 1, "Micle", "Bord", "380635225522", vehicle1, car);
           order1.PrintInfo();
        }
    }
}