using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class AutoPlayer:AbstractPlayer
    {
        const int DEALERHIGHESTPOSSIBLE = 17;

        /// <summary>
        /// Initializes a new instance of the AutoPlayer class with the specified player name and card pool.
        /// </summary>
        /// <param name="name">The name of the player, used to identify the player within the game.</param>
        /// <param name="cardPool">An object that provides the set of cards available for the player to use during the game.</param>
        public AutoPlayer(string name, ICardPool cardPool) : base(name, cardPool)
        {
        }


        public PlayerAction GetNextAction(ICard DealerCard)
        {
            if(GetHandValue() <DEALERHIGHESTPOSSIBLE)
            {
                PlayAction(PlayerAction.Hit);
                return PlayerAction.Hit;
            }
            else if(GetHandValue() >= DEALERHIGHESTPOSSIBLE) 
            { 
                PlayAction(PlayerAction.Stand);
                return PlayerAction.Stand;
            }
            return PlayerAction.None;
        }
    }
}
