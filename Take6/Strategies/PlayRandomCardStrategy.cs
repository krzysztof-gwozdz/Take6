namespace Take6.Strategies;

internal class PlayRandomCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.RandomCard;
}