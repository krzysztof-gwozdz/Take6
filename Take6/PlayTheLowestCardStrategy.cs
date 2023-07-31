namespace Take6;

internal class PlayTheLowestCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Lowest();
}