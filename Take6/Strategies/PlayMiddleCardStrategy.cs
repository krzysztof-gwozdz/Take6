namespace Take6.Strategies;

internal class PlayMiddleCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.MiddleCard;
}