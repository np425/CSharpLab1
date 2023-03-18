namespace Uzd13_a;

public static class Program
{
    private static void Main()
    {
        const int a = 7;
        const double b = 7.5;
        Console.WriteLine($"{a} => {Square(a)}; {b} => {Square(b)}");
    }

    private static double Square(double number)
    {
        return number * number;
    }

    private static int Square(int number)
    {
        return number * number;
    }
}
