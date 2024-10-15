using static System.Console;
using static System.Math;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            Write("Введите значение x: ");
            double x = double.Parse(ReadLine());

            double z = x - 3;

            double y = 4 * Pow(z, 6) - 7 * Pow(z, 3) + 2;

            WriteLine($"Для x = {x}, y = {y}");
        }
    }
}