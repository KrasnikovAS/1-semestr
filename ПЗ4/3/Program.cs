using System;

namespace TypesConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string stringValue = Console.ReadLine();
            long longValue = Convert.ToInt64(stringValue);
            float floatValue = Convert.ToSingle(stringValue);
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}");
        }
    }
}