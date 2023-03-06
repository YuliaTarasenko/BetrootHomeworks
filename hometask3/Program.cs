Console.WriteLine("Enter x");
var stringX = Console.ReadLine();
int.TryParse(stringX, out var x);
Console.WriteLine("Enter y");
var stringY = Console.ReadLine();
int.TryParse(stringY, out var y);
int Sum = 0;
Console.WriteLine();

if (x == y)
{
    Sum = x;
    Console.WriteLine("x = y = " + Sum);
}
else
{
    int min = Math.Min(x, y);
    int max = Math.Max(x, y);
    for (int i = min; i <= max; i++)
    {
        Console.WriteLine(i);
        Sum += i;
    }
    Console.WriteLine();
    Console.WriteLine("The sum of numbers between x and y = " + Sum);
}



