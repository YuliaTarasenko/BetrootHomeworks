namespace SQLQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var orders = GetAllOrders();
            Console.WriteLine();
        }

        static Order[] GetAllOrders()
        {
            using var context = new SampleContext();
            return context.Orders.ToArray();
        }
    }
}