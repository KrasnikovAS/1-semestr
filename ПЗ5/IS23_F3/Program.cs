using System;

class Program
{
    static void Main()
    {
        double x = 9;

        double xSquarе = Math.Pow(x, 2);
        double Cube3 = Math.Pow(3, 3);
        double Sqrt = Math.Sqrt(x);

        double first = 2 * xSquarе;
        double second = 3 * Cube3 * Sqrt;

        double result = first - second;

        Console.WriteLine($"Результат уравнения {result:F2}");
    }
}