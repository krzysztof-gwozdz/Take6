namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class TwoHighestCardStrategyVsTwoLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Highest 1", new PlayHighestCardStrategy()),
            new Player("Highest 2", new PlayHighestCardStrategy()),
            new Player("Lowest 1", new PlayLowestCardStrategy()),
            new Player("Lowest 2", new PlayLowestCardStrategy())
        };
    }
}