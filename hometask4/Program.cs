namespace hometask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MaxValue();
            MaxValue(1, 14, 10);
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
            var isOdd = TrySumIfOdd(x, y, out int sum);
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

        static int MaxValue(int a, int b, int c)=> Math.Max(Math.Max(a, b),c);

        static int MaxValue(params int[] values)
        {
            int max = values.Max();
            return max;
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

        static bool TrySumIfOdd(int start,int end, out int sum)
        {
            sum = 0;
            if(start == end) return false;
            if(start >end)
            {
                int temp = start;
                start = end;
                end = temp;
            }
            for (var i = start+1; i <end; i++)
                sum += i;
            bool isOdd = sum % 2 == 1;
            return isOdd;
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