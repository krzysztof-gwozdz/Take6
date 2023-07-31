namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneHighestCardStrategyVsThreeLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Highest", new PlayHighestCardStrategy()),
            new Player("Lowest 1", new PlayLowestCardStrategy()),
            new Player("Lowest 2", new PlayLowestCardStrategy()),
            new Player("Lowest 3", new PlayLowestCardStrategy())
        };
    }
}