namespace Take6.Strategies;

internal class PlayHighestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.HighestCard;
}