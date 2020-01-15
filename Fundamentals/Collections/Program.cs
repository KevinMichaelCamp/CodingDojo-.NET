using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Three Basic Arrays
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };
            bool[] booleanArray = { true, false, true, false, true, false, true, false, true, false };

            // List of flavors
            List<string> flavors = new List<string>();
            flavors.Add("Chocolate");
            flavors.Add("Vanilla");
            flavors.Add("Mocha");
            flavors.Add("Cookies & Cream");
            flavors.Add("Strawberry");

            for (int idx = 0; idx < flavors.Count; idx++)
            {
                Console.WriteLine(flavors[idx]);
            }
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);

            // Dictionary
            Random rand = new Random();
            Dictionary<string, string> favorites = new Dictionary<string, string>();
            for (int i = 0; i < nameArray.Length; i++)
            {
                favorites.Add(nameArray[i], flavors[rand.Next(nameArray.Length)]);
            }

            foreach (var entry in favorites)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }

        }
    }
}
