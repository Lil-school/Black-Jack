using System.Collections.Generic;

namespace BlackJack.Lib
{
    public interface ICardStack
    {
        List<ICard> Cards { get; }

        Card DrawCard();
        void Shuffle(int numberOfShuffles);
    }
}