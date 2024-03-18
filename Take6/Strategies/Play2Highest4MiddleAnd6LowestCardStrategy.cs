namespace Take6.Strategies;

internal class Play2Highest4MiddleAnd6LowestCardStrategy : IPlayCardStrategy
{
    private int _round = 1;

    public ushort PlayCard(Player player, CardRow[] cardRows) => _round++ switch
    {
        1 => player.Hand.HighestCard,
        2 => player.Hand.HighestCard,
        3 => player.Hand.MiddleCard,
        4 => player.Hand.MiddleCard,
        5 => player.Hand.MiddleCard,
        6 => player.Hand.MiddleCard,
        _ => player.Hand.LowestCard,
    };
}