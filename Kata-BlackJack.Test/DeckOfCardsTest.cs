using System;
using Xunit;
namespace Kata_BlackJack.Test
{
    public class DeckOfCardsTest
    {
        public DeckOfCardsTest()
        {
        }

        [Fact]
        public void ShouldDecreaseDeckSizeByOne_WhenDrawIsCalled()
        {
            var deck = new DeckOfCards();

            deck.Draw();

            Assert.True(deck.GetSize() == 51);
        }
    }
}
