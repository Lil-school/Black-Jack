using System.Text;

namespace BlackJack.Lib
{
    partial class AbstractPlayer
    {

        public override string ToString()
        {
            StringBuilder playerStatus = new StringBuilder();

            playerStatus.Append(_hand);
            if (LastAction == PlayerAction.Stand)
            {
                playerStatus.Append(" (Stand)");
            }

            return $"{_name} : {playerStatus}";
        }
    }
}
