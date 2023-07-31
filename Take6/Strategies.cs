namespace Take6;

interface IPlayACardStrategy
{
    Card PlayACard(Player player, CardRow[] cardRows);
}

internal class PlayRandomCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Random();
}

internal class PlayTheHighestCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Highest();
}

internal class PlayTheLowestCardStrategy : IPlayACardStrategy
{
    public Card PlayACard(Player player, CardRow[] cardRows) => player.Hand.Lowest();
}