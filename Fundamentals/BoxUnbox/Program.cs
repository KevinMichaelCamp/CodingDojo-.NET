using System;
using System.Collections.Generic;

namespace BoxUnbox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> box = new List<object>();
            int sumTotal = 0;
            // Add the following values to the list: 7, 28, -1, true, "chair"
            box.Add(7);
            box.Add(28);
            box.Add(-1);
            box.Add(true);
            box.Add("chair");
            // Loop through the list and print all values (Hint: Type Inference might help here!)
            for (var idx = 0; idx < box.Count; idx++)
            {
                Console.WriteLine(box[idx]);
                // Add all values that are Int type together and output the sum
                if (box[idx] is int)
                {
                    sumTotal += (int)box[idx];
                }
            }
            Console.WriteLine(sumTotal);
        }
    }
}
