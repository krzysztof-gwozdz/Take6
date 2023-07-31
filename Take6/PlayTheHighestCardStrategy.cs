namespace Take6;

internal class PlayTheHighestCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Highest();
}