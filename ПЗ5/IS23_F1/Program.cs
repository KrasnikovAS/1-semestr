using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int number2 = int.Parse(Console.ReadLine());

        int maxNumber = Math.Max(number1, number2);

        Console.WriteLine($"Наибольшее число: {maxNumber}");
    }
}