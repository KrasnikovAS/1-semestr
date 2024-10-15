using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            double deposit = Convert.ToDouble(Console.ReadLine());
            double interest1;
            double bonus = 15;

            if (deposit < 100)
            {
                interest1 = 0.05;
            }
            else if (deposit >= 100 || deposit <= 200)
            {
                interest1 = 0.07;
            }
            else
            {
                interest1 = 0.1;
            }
            double intetest2 = deposit * interest1;
            double result = deposit + intetest2 + bonus;
            Console.WriteLine(result);
        }
    }
}