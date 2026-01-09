using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class CardStack
    {
        public List<Card> Cards { get; }
        const int NUMBER_OF_DECKS = 6;
        public CardStack()
        {
            Cards = new List<Card>();
            for(int deck = 0; deck < NUMBER_OF_DECKS; deck++)
            {
                foreach (CardSuit suit in Enum.GetValues(typeof(CardSuit)))
                {
                    foreach (CardValue value in Enum.GetValues(typeof(CardValue)))
                    {
                        Cards.Add(new Card(suit, value));
                    }
                }
            }
            Shuffle(3);
        }

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
        public Card DrawCard()
        {
            var card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }

    }
}
