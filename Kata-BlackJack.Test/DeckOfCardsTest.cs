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

        [Fact]
        public void ShouldReturnTwoCardsInAnArray_WhenDealIsCalled()
        {
            var deck = new DeckOfCards();
            var result = deck.Deal();

            Assert.True(result.Length == 2);
        }
    }
}
