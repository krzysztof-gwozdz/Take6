namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneTheLowestCardStrategyVsThreeTheHighestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("The Lowest", new PlayTheLowestCardStrategy()),
            new Player("The Highest 1", new PlayTheHighestCardStrategy()),
            new Player("The Highest 2", new PlayTheHighestCardStrategy()),
            new Player("The Highest 3", new PlayTheHighestCardStrategy())
        };
    }
}