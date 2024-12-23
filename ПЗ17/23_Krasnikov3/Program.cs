using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Введите полный путь к текстовому файлу: ");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Файл не найден. Убедитесь, что путь указан правильно.");
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            int maxLength = 0;
            foreach (string line in lines)
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
            }

            Console.WriteLine($"Длина самой длинной строки: {maxLength}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
    }
}
