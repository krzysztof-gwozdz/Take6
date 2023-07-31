namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class TwoTheHighestCardStrategyVsTwoTheLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("The Highest 1", new PlayTheHighestCardStrategy()),
            new Player("The Highest 2", new PlayTheHighestCardStrategy()),
            new Player("The Lowest 1", new PlayTheLowestCardStrategy()),
            new Player("The Lowest 2", new PlayTheLowestCardStrategy())
        };
    }
}