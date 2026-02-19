using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    /// <summary>
    /// Provides factory methods for creating card and card stack instances.
    /// </summary>
    /// <remarks>The Factory class offers static methods to instantiate objects related to cards and card
    /// stacks. Use these methods to create new instances without directly invoking constructors. This approach can help
    /// encapsulate object creation and promote consistency across the application.</remarks>
    public class Factory
    {
        /// <summary>
        /// Creates a new instance of a card stack.
        /// </summary>
        /// <returns>An object that implements the <see cref="ICardStack"/> interface, representing an empty card stack.</returns>
        public static ICardStack CreateCardStack()
        {
            return new CardStack();
        }

        /// <summary>
        /// Creates a new card instance with the specified suit and value.
        /// </summary>
        /// <param name="suit">The suit of the card to create. Must be a valid value from the <see cref="CardSuit"/> enumeration.</param>
        /// <param name="value">The value of the card to create. Must be a valid value from the <see cref="CardValue"/> enumeration.</param>
        /// <returns>A <see cref="Card"/> object representing the card with the specified suit and value.</returns>
        public static Card CreateCard(CardSuit suit, CardValue value)
        {
            return new Card(suit, value);
        }
        /* public static Card CreateCardByCard(ICard card)
        {
            return new Card(card.Suit, card.Value);
        }*/
    }
}
