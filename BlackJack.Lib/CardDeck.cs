using System;

namespace BlackJack.Lib
{
    public class CardDeck
    {
        public Card[] Cards { get; }

        public CardDeck()
        {
            Cards = new Card[52];
            var index = 0;

            foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                {
                    Cards[index] = new Card(suit, value);
                    index++;
                }
            }
        }
    }
}
