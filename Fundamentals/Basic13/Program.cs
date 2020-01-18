using System;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, -9, 25, 42, 5, 0, -42, 22 };
            // Excercises.PrintNumbers();
            // Excercises.PrintOdds();
            // Excercises.PrintSum();
            // Excercises.LoopArray(numArray);
            // Console.WriteLine($"Max value is: {Excercises.FindMax(numArray)}");
            // Excercises.GetAverage(numArray);
            // int[] odds = Excercises.OddArray();
            // foreach (var num in odds)
            // {
            //     Console.WriteLine(num);
            // }
            // Console.WriteLine(Excercises.GreaterThanY(numArray, 5));
            // Excercises.SquareArrayValues(numArray);
            // Excercises.EliminateNegatives(numArray);
            // Excercises.MinMaxAverage(numArray);
            // Excercises.ShiftValues(numArray);
            object[] box = Excercises.NumToString(numArray);
            foreach (var item in box)
            {
                Console.WriteLine(item);
            }
        }
    }
}
