using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string first_name = "Kevin";
            string last_name = "Camp";
            string message = $"Hello {first_name} {last_name}!";
            Console.WriteLine(message);
            Console.WriteLine("My name is {0}, I am " + 28 + " years old", "Tim");
            // Random numbers / loops
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(rand.Next(0, 10));
            }

        }
    }
}
