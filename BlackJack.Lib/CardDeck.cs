using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    /// <summary>
    /// Represents a standard deck of 52 playing cards.
    /// </summary>
    public class CardDeck
    {
        public Card[] Cards { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CardDeck"/> class with a full set of 52 cards.
        /// Creates one card for each combination of suit and value.
        /// </summary>
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
