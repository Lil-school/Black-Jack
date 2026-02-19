using System.Collections.Generic;
using System.Linq;

namespace BlackJack.Lib
{
    /// <summary>
    /// Represents a collection of playing cards held by a player, along with the current status of the hand in a card
    /// </summary>
    public partial class Hand
    {
        /// <summary>
        /// Gets the collection of cards currently held in the hand.
        /// </summary>
        List<ICard> GetHand { get; } =new List<ICard>();

        /// <summary>
        /// Gets or sets the current status of the hand.
        /// </summary>
        public HandStatus Status { get; private set; }

        /// <summary>
        /// Initializes a new instance of the Hand class and updates its status.
        /// </summary>
        /// <remarks>The constructor calls UpdateHandStatus to ensure the hand's initial state is set. Use this
        /// constructor to create a Hand object with its status properly initialized.</remarks>
        public Hand() 
        {
            CalculateValue();
        }

        /// <summary>
        /// Adds a card to the current hand.
        /// </summary>
        /// <param name="card">The card to add to the hand. Cannot be null.</param>
        public void AddCard(ICard card)
        {
            GetHand.Add(card);
        }

        /// <summary>
        /// Calculates the total value of the current hand according to standard Blackjack rules.
        /// </summary>
        /// <returns>The total value of the hand as an integer. The value will be between 0 and 21 or higher if the hand is bust.</returns>
        public int CalculateValue()
        {
            int handValue = 0;
            int numberOfAces = 0;
            foreach (var card in GetHand)
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
            }
            UpdateHandStatus(handValue);
            return handValue;
        }

        /// <summary>
        /// Updates the hand status based on the current cards and their total value.
        /// </summary>
        /// <remarks>This method determines whether the hand is busted, a blackjack, a triple seven, a
        /// five card charlie, or safe, according to standard blackjack rules and special conditions. Call this method
        /// after modifying the hand to ensure the status reflects the latest state.</remarks>
        void UpdateHandStatus(int handValue) 
        { 
            
            if (handValue > 21)
            {
                Status = HandStatus.Busted;
            }
            else if (handValue==21 && GetHand.Count ==2)
            {
                Status= HandStatus.BlackJack;
            }
            else if (handValue == 21 && GetHand.Count == 3 && GetHand.All(c => c.Value == CardValue.Seven))
            {
                Status = HandStatus.TripleSeven;
            }
            else if (handValue ==21 && GetHand.Count == 5)
            {
                Status = HandStatus.FiveCardCharlie;
            }
            else
            {
                Status = HandStatus.Safe;
            }
        }
    }
}
