namespace DelegateLambda;

class CalculationService
{
    public static void Max(double x, double y)
    {
        Console.WriteLine((x > y) ? x : y);
    }
    public static void Sum(double x, double y)
    {
        Console.WriteLine(x + y);
    }
    public static void Square(double x)
    {
        Console.WriteLine(x * x);
    }
}