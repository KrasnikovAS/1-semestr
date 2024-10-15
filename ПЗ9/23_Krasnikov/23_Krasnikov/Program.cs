using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите сумму вклада:");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Введите количество месяцев:");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal result = deposit;
        decimal p = 0.07m;

        for (int i = 0; i < months; i++)
        {
            decimal interest = result * p;
            result += interest;
        }

        Console.WriteLine($"Конечная сумма вклада: {result:C}");
    }
}