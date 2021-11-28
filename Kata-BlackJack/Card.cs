using System;
namespace Kata_BlackJack
{
    public class Card
    {
        public string Suit { get; set; }
        public string Value { get; set; }

        public Card(String suit, String value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
