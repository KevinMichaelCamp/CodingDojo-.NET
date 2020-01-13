using System;

namespace Fun1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Loop that prints all values from 1-255
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int j = 1; j <= 100; j++)
            {
                if ((j % 3 == 0) && (j % 5 != 0))
                {
                    Console.WriteLine(j + "Fizz");
                }
                else if ((j % 3 != 0) && (j % 5 == 0))
                {
                    Console.WriteLine(j + "Buzz");
                }
                else if ((j % 3 == 0) && (j % 5 == 0))
                {
                    Console.WriteLine(j + "FizzBuzz");
                }
            }
            // Use while loop
            int k = 1;
            while (k <= 100)
            {
                if ((k % 3 == 0) && (k % 5 != 0))
                {
                    Console.WriteLine(k + "Fizz");
                }
                else if ((k % 3 != 0) && (k % 5 == 0))
                {
                    Console.WriteLine(k + "Buzz");
                }
                else if ((k % 3 == 0) && (k % 5 == 0))
                {
                    Console.WriteLine(k + "FizzBuzz");
                }
                k++;
            }
        }
    }
}
