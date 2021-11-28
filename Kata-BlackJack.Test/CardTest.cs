using System;
using Xunit;

namespace Kata_BlackJack.Test
{
    public class CardTest
    {
        [Fact]
        public void AnAceOfHeart_ShouldHaveASuitOfHeart()
        {
            var suit = "Heart";
            var card = new Card(suit,"One");

            Assert.Equal(card.Suit, suit);
        }

        [Fact]
        public void AnAceCard_ShouldHaveAValueOfAce()
        {
            var value = "Ace";
            var card = new Card("SUIT", value);

            Assert.Equal(card.Value, value);
        }
    }
}