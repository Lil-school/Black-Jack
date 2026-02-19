namespace BlackJack.Lib
{
    public interface ICard
    {
        CardSuit Suit { get; }
        CardValue Value { get; }
    }
}