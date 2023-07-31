namespace Take6;

internal class PlayRandomCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Random();
}