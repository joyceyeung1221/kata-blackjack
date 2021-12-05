using System;
using System.Collections.Generic;
namespace Kata_BlackJack
{
    public class DeckOfCards
    {
        private List<Card> cards = new List<Card>();

        public DeckOfCards()
        {
            PopulateList();
        }

        public Card Draw()
        {
            var card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public int GetSize()
        {
            return cards.Count;
        }

        private void PopulateList()
        {
            for(var i = 0; i <=51; i++)
            {
                cards.Add(new Card("WHATEVER", "Heart"));
            }
        }

        public Card[] Deal()
        {
            var dealtCards = new Card[2];
            for (int i = 0; i < 2; i++)
            {
                dealtCards[i] = Draw();
            }
            return dealtCards;
        }

    } 
}
