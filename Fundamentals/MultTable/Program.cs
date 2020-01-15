using System;

namespace MultTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] multArray = new int[10, 10];
            for (int row = 0; row < 10; row++)
            {
                for (int col = 0; col < 10; col++)
                {
                    multArray[row, col] = (row + 1) * (col + 1);
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(multArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
