using System;

namespace TypesConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 10;
            byte byteValue = (byte)intValue;
            long longValue = intValue;
            float floatValue = intValue;
            double doubleValue = intValue;
            Console.WriteLine($"Переменная типа int = {intValue}");
            Console.WriteLine($"Переменная типа byte = {byteValue}");
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}"); 
            Console.WriteLine($"Переменная типа Value = {doubleValue}");
        }
    }
}