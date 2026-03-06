using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    /// <summary>
    /// Represents an abstract player in a card game, providing a base for implementing player-specific behaviors and
    /// managing the player's hand and actions.
    /// </summary>
    public abstract partial class AbstractPlayer
    {
        string _name;
        protected Hand _hand;
        ICardPool _cardPool;
        const int HIGHESTPOSSIBLEVALUE = 21;

        /// <summary>
        /// Gets the most recent action performed by the player.
        /// </summary>
        /// <remarks>The property is initialized to <see cref="PlayerAction.None"/>, indicating that no
        /// action has been taken yet. The value updates each time the player performs an action during
        /// gameplay.</remarks>
        public PlayerAction LastAction { get; private set; } = PlayerAction.None;

        /// <summary>
        /// Gets a value indicating whether the operation has completed.
        /// </summary>
        public bool HasFinished { get; private set; }

        /// <summary>
        /// Initializes a new instance of the AbstractPlayer class with the specified player name and associated card
        /// pool.
        /// </summary>
        /// <remarks>This constructor also initializes the player's hand and links it to the provided card
        /// pool.</remarks>
        /// <param name="name">The name of the player. Cannot be null or empty.</param>
        /// <param name="cardPool">The card pool to associate with the player. Cannot be null.</param>
        internal AbstractPlayer(string name, ICardPool cardPool)
        {
            _name = name;
            _cardPool = cardPool;
            _hand = new Hand();
        }

        /// <summary>
        /// Processes the specified player action and updates the game state accordingly.
        /// </summary>
        /// <param name="action">The action to perform for the current turn. Specify <see cref="PlayerAction.Stand"/> to end the turn, or
        /// <see cref="PlayerAction.Hit"/> to draw a new card if the hand value is less than 21.</param>
        public void PlayAction(PlayerAction action)
        {
            if (action == PlayerAction.Stand)
            {
                HasFinished = true;
            }
            else if (action == PlayerAction.Hit && GetHandValue() < HIGHESTPOSSIBLEVALUE && LastAction !=  PlayerAction.Stand)
            {
                _hand.AddCard(_cardPool.DrawCard());
                HasFinished = false;
            }
            LastAction = action;
        }


        /// <summary>
        /// Resets the player's hand and marks the game as not finished if the game has concluded.
        /// </summary>
        public void ThrowCards()
        {
            if (HasFinished)
            {
                _hand = new Hand();
                HasFinished = false;
            }
        }

        /// <summary>
        /// Gets the name associated with the current instance.
        /// </summary>
        /// <returns>The name as a string, which represents the current instance's name.</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Calculates and returns the total value of the current hand based on its cards.
        /// </summary>
        /// <returns>An integer representing the total value of the hand, as determined by the current cards held.</returns>
        public int GetHandValue()
        {
            return _hand.CalculateValue();
        }

        /// <summary>
        /// Gets the current status of the hand.
        /// </summary>
        /// <returns>The current status of the hand as a <see cref="HandStatus"/> enumeration value.</returns>
        public HandStatus GetHandStatus()
        {
            return _hand.Status;
        }
    }
}