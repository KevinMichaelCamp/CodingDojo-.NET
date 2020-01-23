using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "AT&T", "Trill Trill Trill");
            Nokia elevenHundred = new Nokia("1100", 60, "Metro PCS", "Ring Ring Ring");

            s8.DisplayInfo();
            Console.WriteLine(s8.Ring());
            Console.WriteLine(s8.Unlock());
            Console.WriteLine(s8.Ring());
            Console.WriteLine("");

            elevenHundred.DisplayInfo();
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine(elevenHundred.Unlock());
            Console.WriteLine(elevenHundred.Ring());
            Console.WriteLine("");


        }
    }
}
