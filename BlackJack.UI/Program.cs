using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Lib;

namespace BlackJack.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card(CardSuit.Heart, CardValue.Ace);
            Console.WriteLine(card.ToString());

            Console.ReadLine();

            CardDeck cardDeck= new CardDeck();
            foreach (var deckCard in cardDeck.Cards)
            {
                Console.WriteLine($"CardValue: {deckCard.Value}     CardSuit: {deckCard.Suit}");
            }

            Console.ReadLine();


            Console.ReadKey();
        }
    }
}
