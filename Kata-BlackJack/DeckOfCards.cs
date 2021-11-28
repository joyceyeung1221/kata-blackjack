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

        public void Draw()
        {
            cards.RemoveAt(0);
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
    } 
}
