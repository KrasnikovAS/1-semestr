using static System.Console;
using static System.Math;

class Program
{
    static void Main()
    {
        Write("Введите координату x (1-8): ");
        int x = int.Parse(ReadLine());

        Write("Введите координату y (1-8): ");
        int y = int.Parse(ReadLine());

        bool isWhite = (x + y) % 2 == 1;

        WriteLine($"Клетка с координатами ({x}, {y}) белая: {isWhite}");
    }
}