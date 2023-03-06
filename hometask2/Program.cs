Assignments();
MathEquations();
//Dates();
void Assignments()
{
    int val1 = 4;
    double val2 = 3.23;
    char letter = 'b';
    string greeting = "Have a good day";
    decimal a = 2.1m;
    bool check = true;

    var addition = val1 + val2;
    var subtraction = val2 - val1;
    var multiple = val1 * val2;
    Console.WriteLine(greeting + " " + letter);
    Console.WriteLine();
    Console.WriteLine($"Results: addition = {addition}; substraction = {subtraction}; multiple = {multiple}.");
    Console.WriteLine();
}

void MathEquations()
{
    Console.WriteLine("Enter x");
    var stringX = Console.ReadLine();
    //var x = int.Parse(stringX);
    int.TryParse(stringX, out var x);
    Console.WriteLine("Enter y");
    var stringY = Console.ReadLine();
    //var y = int.Parse(stringY);
    int.TryParse(stringY, out var y);
    var a = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
    var b = Math.Abs(x) * Math.Sin(x);
    var c = 2 * Math.PI * x;
    var d = Math.Max(x, y);

    Console.WriteLine($"-6*x^3+5*x^2-10*x+15 = {a}");
    Console.WriteLine($"abs(x) * sin(x) = {b}");
    Console.WriteLine($"2 * pi * x = {c}");
    Console.WriteLine($"max(x,y) = {d}");
    Console.WriteLine();
}

void Dates()
{
    var datetime = DateTime.Now;
    var days = DateTime.DaysInMonth( datetime.Year, datetime.Month );

    Console.WriteLine(days);
    //var dateNY = datetime.Year + 1; 
    //var dateLY = datetime.Year - 1;
    
    //Console.WriteLine(dateNY); Console.WriteLine(dateLY);
    //Console.WriteLine("X days left to New Year");
    //Console.WriteLine("Y days passed from New Year");
    //Console.WriteLine("Inpute date: ");
    //var strDate = Console.ReadLine();
    //DateOnly.TryParse(strDate, out var dateonly);
    //Console.WriteLine($"Your date is - {dateonly}");
    //Console.WriteLine("X days left to New Year from your date");
    //Console.WriteLine("Y days passed from New Year since your date");
}
