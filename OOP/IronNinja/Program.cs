using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetTooth sweety = new SweetTooth();
            SpiceHound spiceguy = new SpiceHound();
            Buffet buffet = new Buffet();

            while (!sweety.IsFull)
            {
                sweety.Consume(buffet.Serve());
            }

            while (!spiceguy.IsFull)
            {
                spiceguy.Consume(buffet.Serve());
            }

            Ninja winner;
            string title;

            if (sweety.ConsumptionHistory.Count >= spiceguy.ConsumptionHistory.Count)
            {
                winner = sweety;
                title = "Sweet Tooth";
            }
            else
            {
                winner = spiceguy;
                title = "Spice Hound";
            }

            Console.WriteLine($"{title} is the winner, with {winner.ConsumptionHistory.Count} items consumed!");

        }
    }
}
