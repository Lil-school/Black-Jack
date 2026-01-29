using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    /// <summary>
    /// Represents a stack of playing cards composed of multiple decks, providing functionality to shuffle and draw
    /// cards.
    /// </summary>
    public class CardStack
    {
        public List<Card> Cards { get; }

        const int NUMBER_OF_DECKS = 6;

        /// <summary>
        /// Initializes a new instance of the CardStack class containing cards from multiple decks and shuffles them.
        /// </summary>
        public CardStack()
        {
            Cards = new List<Card>();
            for(int deck = 0; deck < NUMBER_OF_DECKS; deck++)
            {
                CardDeck cardDeck = new CardDeck();
                Cards.AddRange(cardDeck.Cards);
            }
            Shuffle(3);
        }

        /// <summary>
        /// Randomizes the order of the cards in the collection by performing the specified number of shuffle passes.
        /// </summary>
        /// <param name="numberOfShuffles">The number of times to shuffle the card collection. Must be greater than zero; higher values increase the
        /// degree of randomization.</param>
        public void Shuffle(int numberOfShuffles)
        {
            var rand = new Random();
            for(int i= 0; i < numberOfShuffles; i++)
            {
               for(int j = 0; j < Cards.Count; j++)
                {
                    int random = rand.Next(Cards.Count);
                    var temp = Cards[j];
                    Cards[j] = Cards[random];
                    Cards[random] = temp;
                }
            }

        }

        /// <summary>
        /// Removes and returns the top card from the deck.
        /// </summary>
        /// <returns>The card that was at the top of the deck.</returns>
        public Card DrawCard()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

    }
}
