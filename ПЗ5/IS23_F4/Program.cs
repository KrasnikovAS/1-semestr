using System;

class Program
{
    static void Main()
    {
        double x = 4;

        double xSquarе = Math.Pow(x, 2);

        double first = 5 * xSquarе - 12 * x + 4;
        double second = 6 - 15 * x;

        double result = first / second;

        Console.WriteLine($"Результат уравнения {result:F2}");
    }
}