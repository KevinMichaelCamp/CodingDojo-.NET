using System;

namespace Basic13
{
    public static class Excercises
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i < 256; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i += 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintSum()
        {
            int total = 0;
            for (int i = 1; i < 256; i++)
            {
                total += i;
                Console.WriteLine($"New number: {i} Sum: {total}");
            }
        }
        public static void LoopArray(int[] numbers)
        {
            int count = numbers.Length;
            for (int idx = 0; idx < count; idx++)
            {
                Console.WriteLine(numbers[idx]);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int count = numbers.Length;
            int max = numbers[0];
            for (int idx = 0; idx < count; idx++)
            {
                if (numbers[idx] > max)
                {
                    max = numbers[idx];
                }
            }
            return max;
        }
        public static void GetAverage(int[] numbers)
        {
            int count = numbers.Length;
            double average;
            int total = 0;
            for (int idx = 0; idx < count; idx++)
            {
                total += numbers[idx];
            }
            average = Convert.ToDouble(total) / Convert.ToDouble(count);
            Console.WriteLine($"Average: {average}");
        }
        public static int[] OddArray()
        {
            int size = (255 / 2) + 1;
            int[] oddArray = new int[size];
            int idx = 0;
            for (int num = 1; num <= 255; num += 2)
            {
                oddArray[idx] = num;
                idx++;
            }
            return oddArray;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int length = numbers.Length;
            int count = 0;
            for (int idx = 0; idx < length; idx++)
            {
                if (numbers[idx] > y)
                {
                    count++;
                }
            }
            return count;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            int count = numbers.Length;
            for (int idx = 0; idx < count; idx++)
            {
                numbers[idx] = numbers[idx] * numbers[idx];
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            int count = numbers.Length;
            for (int idx = 0; idx < count; idx++)
            {
                if (numbers[idx] < 0)
                {
                    numbers[idx] = 0;
                }
            }
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int count = numbers.Length;
            int min = numbers[0];
            int max = numbers[0];
            int total = 0;
            double average;
            for (int idx = 0; idx < count; idx++)
            {
                total += numbers[idx];
                if (numbers[idx] < min)
                {
                    min = numbers[idx];
                }
                if (numbers[idx] > max)
                {
                    max = numbers[idx];
                }
            }
            average = Convert.ToDouble(total) / Convert.ToDouble(count);
            Console.WriteLine($"Min Value: {min} | Max Value: {max} | Average: {average}");
        }
        public static void ShiftValues(int[] numbers)
        {
            int count = numbers.Length;
            for (int idx = 0; idx < count - 1; idx++)
            {
                numbers[idx] = numbers[idx + 1];
            }
            numbers[count - 1] = 0;
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public static object[] NumToString(int[] numbers)
        {
            int size = numbers.Length;
            object[] box = new object[size];
            for (int idx = 0; idx < size; idx++)
            {
                if (numbers[idx] >= 0)
                {
                    box[idx] = numbers[idx];
                }
                else
                {
                    box[idx] = "Dojo";
                }
            }
            return box;
        }
    }
}