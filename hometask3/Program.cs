int x = 0;
bool success = false;

while (!success)
{
    Console.Write("Enter x: ");

    if (int.TryParse(Console.ReadLine(), out x))
    {
        success = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}

int y = 0;
bool success1 = false;
while (!success1)
{
    Console.WriteLine("Enter y: ");
    if (int.TryParse(Console.ReadLine(),out y))
    {
        success1 = true;
    }
    else
    {
        Console.WriteLine("Invalid input. Please try again.");
    }
}

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