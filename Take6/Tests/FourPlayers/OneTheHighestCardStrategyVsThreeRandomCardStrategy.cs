namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneTheHighestCardStrategyVsThreeRandomCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("The Highest", new PlayTheHighestCardStrategy()),
            new Player("Random 1", new PlayRandomCardStrategy()),
            new Player("Random 2", new PlayRandomCardStrategy()),
            new Player("Random 3", new PlayRandomCardStrategy())
        };
    }
}