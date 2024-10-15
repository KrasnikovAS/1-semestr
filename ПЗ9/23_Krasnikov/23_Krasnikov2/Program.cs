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

        int i = 0;
        while (i < months)
        {
            decimal interest = result * p;
            result += interest;
            i++;
        }


        Console.WriteLine($"Конечная сумма вклада: {result:C}");
    }
}