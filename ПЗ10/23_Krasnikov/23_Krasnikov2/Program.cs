using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите последовательность чисел и закончите ввод нулем");

        int num;
        int maxNum = int.MinValue;
        int i = 0;
        int pi = 0;
        do
        {
            num = Convert.ToInt32(Console.ReadLine());
            i++;

            if (num > maxNum && num != 0)
            {
                maxNum = num;
                pi = i;
            }

        } while (num != 0);

        Console.WriteLine($"Минимальное число: {maxNum}; Порядковый номер: {pi}");
    }
}

