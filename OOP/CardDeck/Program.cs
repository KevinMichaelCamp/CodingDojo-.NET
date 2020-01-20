using System;

namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            // Write new deck to console
            // foreach (var card in deck.Cards)
            // {
            //     card.SayCard();
            // }
            deck.Shuffle();

            Player player = new Player("Kevin");
            Console.WriteLine(player.Name);
            for (int i = 1; i < 6; i++)
            {
                player.Draw(deck);
            }
            foreach (var card in player.Hand)
            {
                card.SayCard();
            }
            player.Discard(1);
            Console.WriteLine("Discarding card #2...");
            foreach (var card in player.Hand)
            {
                card.SayCard();
            }
        }
    }
}
