namespace Take6.Strategies;

internal class PlayLowestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.LowestCard;
}