using System;

class Program
{
    static void Main()
    {
        double x = 2;
        double y = 5;

        double first = x - y;
        double second = 1 + x * y;

        double result = first / second;

        Console.WriteLine($"Результат уравнения {result:F2}");
    }
}