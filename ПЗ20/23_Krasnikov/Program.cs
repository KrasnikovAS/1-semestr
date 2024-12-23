using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность чисел, заканчивающуюся 0:");
        int result = Sum();
        Console.WriteLine($"Сумма всех чисел: {result}");
    }

    static int Sum()
    {
        int temp = Convert.ToInt32(Console.ReadLine());

        if (temp == 0)
        {
            return 0;
        }
        else
        {
            return temp + Sum();
        }
    }
}
