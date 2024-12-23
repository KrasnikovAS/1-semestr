using System;

class Program
{
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        float[] floatArray = { 1.1f, 2.2f, 3.3f, 4.4f, 5.5f };

        Console.WriteLine("Среднее арифметическое для int: " + AverageMethods.Average(intArray));

        Console.WriteLine("Среднее арифметическое для float: " + AverageMethods.Average(floatArray));
    }
}

class AverageMethods
{
    public static double Average(int[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }

    public static float Average(float[] numbers)
    {
        if (numbers.Length == 0)
            return 0;

        float sum = 0;
        foreach (float number in numbers)
        {
            sum += number;
        }

        return sum / numbers.Length;
    }
}
