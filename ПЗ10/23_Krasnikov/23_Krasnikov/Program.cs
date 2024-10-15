using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность чисел и закончите ввод нулем");

        int num;
        int minNum = int.MaxValue;
        do
        {
            num = Convert.ToInt32(Console.ReadLine());

            if (num < minNum && num != 0)
            {
                minNum = num;
            }

        } while (num != 0);

        Console.WriteLine($"Минимальное число: {minNum}");
    }
}

