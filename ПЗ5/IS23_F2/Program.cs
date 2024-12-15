using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = double.Parse(Console.ReadLine());

        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

        Console.WriteLine($"c = {c:F2}");
    }
}