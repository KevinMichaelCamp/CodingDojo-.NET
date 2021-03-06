using System;

namespace CardDeck
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int value;
        public static string[] Suits = new string[4] { "Spades", "Hearts", "Diamonds", "Clubs" };
        public Card(string s, int val)
        {
            switch (val)
            {
                case 11:
                    stringVal = "Jack";
                    break;
                case 12:
                    stringVal = "Queen";
                    break;
                case 13:
                    stringVal = "King";
                    break;
                case 1:
                    stringVal = "Ace";
                    break;
                default:
                    stringVal = val.ToString();
                    break;
            }
            suit = s;
            value = val;
        }
        public void SayCard()
        {
            Console.WriteLine($"The {stringVal} of {suit}");
        }
    }
}