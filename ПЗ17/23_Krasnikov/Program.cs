using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "..\\..\\..\\numbers.txt";

        try
        {
            string numbers = string.Join(",", Enumerable.Range(1, 500));

            // Запись в файл
            File.WriteAllText(filePath, numbers);

            Console.WriteLine($"Файл '{filePath}' успешно создан.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
