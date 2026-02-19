using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Factory
    // Class not implemented yet
    {
        public static ICardStack CreateCardStack()
        {
            return new CardStack();
        }

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
