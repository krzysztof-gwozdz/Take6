namespace Take6;

interface IPlayCardStrategy
{
    Card PlayCard(Player player, CardRow[] cardRows);
}

internal class PlayRandomCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Random();
}

internal class PlayHighestCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Highest();
}

internal class PlayLowestCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Lowest();
}