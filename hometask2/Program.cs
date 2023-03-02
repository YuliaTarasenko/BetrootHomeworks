//-6*x^3+5*x^2-10*x+15
//abs(x) * sin(x)
//2 * pi * x
//max(x, y)

Console.WriteLine("Enter x");
int x = Console.Read();
double a = -6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15;
double b = Math.Abs(x) * Math.Sin(x);
double c = 2 * Math.PI * x;
Console.WriteLine($"-6*x^3+5*x^2-10*x+15 = {a}");
Console.WriteLine($"abs(x) * sin(x) = {b}");
Console.WriteLine($"2 * pi * x = {c}");