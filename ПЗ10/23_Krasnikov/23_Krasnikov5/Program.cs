using System;

class Program
{
    static void Main(string[] args)
    {
        for (int row = 1; row <= 8; row++)
        {
            for (int col = 1; col <= 8; col++)
            {

                char symbol = (row % 2 == col % 2) ? 'X' : 'O';
                Console.Write(symbol + " ");
            }
            Console.WriteLine();
        }
    }
}