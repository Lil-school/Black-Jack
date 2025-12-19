using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Card
    {
        public CardSuit Suit { get; }
        public CardValue Value { get; }
        public Card(CardSuit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }
        public override string ToString()
        {
            
        }
    }
}
