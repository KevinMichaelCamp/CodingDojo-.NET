using System;
using System.Collections.Generic;

namespace Puzzles
{
    public static class Examples
    {
        public static int[] RandomArray()
        {
            Random rand = new Random();
            int size = 10;
            int[] randArray = new int[size];
            // Create array with 10 random numbers (5-25)
            for (int idx = 0; idx < size; idx++)
            {
                randArray[idx] = rand.Next(5, 26);

            }
            // Min, Max, Sum
            int min = randArray[0];
            int max = randArray[0];
            int total = 0;
            for (int i = 0; i < size; i++)
            {
                total += randArray[i];
                if (randArray[i] > max)
                {
                    max = randArray[i];
                }
                if (randArray[i] < min)
                {
                    min = randArray[i];
                }
            }
            Console.WriteLine($"Min Value: {min} | Max Value: {max} | Sum: {total}");
            return randArray;
        }
        public static string TossCoin()
        {
            Random rand = new Random();
            int result = rand.Next(2);
            if (result == 0)
            {
                return "Heads";
            }
            else
            {
                return "Tails";
            }
        }
        public static double TossMultipleCoins(int num)
        {
            Random rand = new Random();
            int count = 0;
            double ratio;
            for (int flip = 1; flip <= num; flip++)
            {
                int result = rand.Next(2);
                if (result == 0)
                {
                    count++;
                }
            }
            ratio = Convert.ToDouble(count) / Convert.ToDouble(num);
            return ratio;
        }
        public static List<string> Names()
        {
            Random rand = new Random();
            List<string> names = new List<string>()
            {
                "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
            };
            // Shuffle names in list
            int count = names.Count;
            for (var i = 0; i < count / 2; i++)
            {
                int randIdx = rand.Next(count);
                string temp = names[randIdx];
                names[randIdx] = names[i];
                names[i] = temp;
            }
            // print shuffled list
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            // Remove names 5 char or less
            for (var idx = 0; idx < count; idx++)
            {
                if (names[idx].Length <= 5)
                {
                    names.RemoveAt(idx);
                }
            }
            return names;
        }
    }
}