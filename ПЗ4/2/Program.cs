using System;

namespace TypesConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatValue = 10.32f;
            byte byteValue = Convert.ToByte(floatValue); 
            long longValue = Convert.ToInt64(floatValue); 
            int intValue = Convert.ToInt32(floatValue); 
            double doubleValue = floatValue; 
            
            Console.WriteLine($"Переменная типа int = {intValue}");
            Console.WriteLine($"Переменная типа byte = {byteValue}");
            Console.WriteLine($"Переменная типа long = {longValue}");
            Console.WriteLine($"Переменная типа float = {floatValue}"); 
            Console.WriteLine($"Переменная типа double = {doubleValue}");
        }
    }
}