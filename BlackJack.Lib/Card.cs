using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    /// <summary>
    /// Represents a standard playing card with a suit and a value.
    /// </summary>
    public class Card : ICard
    {
        /// <summary>
        /// Gets the suit of the card.
        /// </summary>
        public CardSuit Suit { get; }

        /// <summary>
        /// Gets the value of the card.
        /// </summary>
        public CardValue Value { get; }

        /// <summary>
        /// Initializes a new instance of the Card class with the specified suit and value.
        /// </summary>
        /// <param name="suit">The suit of the card to assign.</param>
        /// <param name="value">The value of the card to assign.</param>
        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        /// <summary>
        /// Returns a string that represents the value and suit of the card.
        /// </summary>
        /// <returns>A string in the format "{Value} of {Suit}s" that describes the card.</returns>
        public override string ToString()
        {
            return $"{Value} of {Suit}s";
        }
    }
}
