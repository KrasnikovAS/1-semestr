using System;
namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите первое число:");
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int c2 = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1:
                    Console.WriteLine(c1 + c2);
                    break;
                case 2:
                    Console.WriteLine(c1 - c2);
                    break;
                case 3:
                    Console.WriteLine(c1 * c2);
                    break;
                default:
                    Console.WriteLine("Операция неопределена");
                    break;
            }
        }
    }
}