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
            var card = new Card(suit);

            Assert.Equal(card.Suit, "Heart");
        }

    }
}
