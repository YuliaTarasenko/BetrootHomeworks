namespace hometask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxValue();
            MaxValue(10, 156, 1);
            MaxValue(14, 5, 22, 18);

            MinValue();
            MinValue(3, 5, 16);
            MinValue(4, 10, 1, 2);

            Console.WriteLine("Enter x: ");
            var stringX = Console.ReadLine();
            int.TryParse(stringX, out int x);
            Console.WriteLine("Enter y: ");
            var stringY = Console.ReadLine();
            int.TryParse(stringY, out int y);
            TrySumIfOdd(x, y);
            Console.WriteLine();

            Repeat("text", 4);
        }

        static void MaxValue()
        { 
            var rand = new Random();
            var x = rand.Next(100);
            var y = rand.Next(100);
            var maxValue = Math.Max(x, y);
            Console.WriteLine($"x = {x}; y = {y}; Max Value = {maxValue}");
            Console.WriteLine();
        }

        static int MaxValue(int x, int y, int z)
        {
            int[]a = { x, y, z };
            var result = a.Max();
            Console.WriteLine($"x = {x}; y = {y}; z = {z};  Max Value = {result}");
            Console.WriteLine();
            return result;
        }

        static int MaxValue(int a, int b, int c, int d)
        {
            int[] array = { a,b,c,d };
            var result = array.Max();
            Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}; Max Value = {result}");
            Console.WriteLine();
            return result;
        }

        static void MinValue()
        {
            var rand = new Random();
            var x = rand.Next(100);
            var y = rand.Next(100);
            var minValue = Math.Min(x, y);
            Console.WriteLine($"x = {x}; y = {y}; Min Value = {minValue}");
            Console.WriteLine();
        }

        static int MinValue(int x, int y, int z)
        {
            int[] a = { x, y, z };
            var result = a.Min();
            Console.WriteLine($"x = {x}; y = {y}; z = {z};  Min Value = {result}");
            Console.WriteLine();
            return result;
        }

        static int MinValue(int a, int b, int c, int d)
        {
            int[] array = { a, b, c, d };
            var result = array.Min();
            Console.WriteLine($"a = {a}; b = {b}; c = {c}; d = {d}; Min Value = {result}");
            Console.WriteLine();
            return result;
        }

        static bool TrySumIfOdd(int x, int y)
        {
            int sum = x + y;
            if (sum%2 == 1)
            {
                Console.WriteLine("Sum is odd and = " + sum);
                return true;
            }
            Console.WriteLine("Sum = " + sum);
            return false;
        }

        static void Repeat (string text, int count)
        {
            for(int i =1; i <= count; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}