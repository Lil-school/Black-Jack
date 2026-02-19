using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Hand
    {
        List<ICard> Hands { get; } =new List<ICard>();
        HandStatus _handStatus { get; set; }
        public Hand() 
        {
            UpdateHandStatus();
        }
        public void AddCard(ICard card)
        {
            Hands.Add(card);
        }
        public int CalculateHandValue()
        {
            int handValue = 0;
            int numberOfAces = 0;
            foreach (var card in Hands)
            {
                if(card.Value==CardValue.Ace)
                {
                    numberOfAces++;
                    handValue += 11;
                }
                else if (card.Value >= CardValue.Jack && card.Value <= CardValue.King)
                {
                    handValue += 10;
                }
                else
                {
                    handValue += (int)card.Value;
                }
            }
            while(handValue > 21 && numberOfAces > 0)
            {
                handValue -= 10;
                numberOfAces--;
                _handStatus = HandStatus.Safe;
            }
            return handValue;
        }
        void UpdateHandStatus() 
        { 
            int handValue=CalculateHandValue();
            if (handValue > 21)
            {
                _handStatus = HandStatus.Busted;
            }
            else if (handValue==21 && Hands.Count ==2)
            {
                _handStatus= HandStatus.BlackJack;
            }
            else if (handValue == 21 && Hands.Count == 3 && )

        }
    }
}
