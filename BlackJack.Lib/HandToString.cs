using System.Text;

namespace BlackJack.Lib
{
    public partial class Hand
    {
        public override string ToString()
        {
            StringBuilder handAsString = new StringBuilder();

            foreach (Card card in GetHand)
            {
                handAsString.Append(card.ToString());
                handAsString.Append(", ");
            }
            if (handAsString.Length > 2)
            {
                handAsString.Remove(handAsString.Length - 2, 2);
            }

            handAsString.Append(" (");
            handAsString.Append(CalculateValue());
            handAsString.Append("/");
            handAsString.Append(Status);
            handAsString.Append(")");

            return handAsString.ToString();

        }

    }
}

