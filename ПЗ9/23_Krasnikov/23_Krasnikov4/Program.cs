using System;

class Program
{
    static void Main(string[] args)
    { 

        while (true)
        {
            Console.WriteLine("Введите первое число:");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double n2 = Convert.ToDouble(Console.ReadLine());

            if ((n1 >=0 && n1 <= 10)&&(n2 >=0 && n2 <= 10))
            {
                Console.WriteLine(n1 * n2);
                break;
            }
            else
            {
                Console.WriteLine("Введенные числа недопустимы");
                continue;
            }
        }
    }
}