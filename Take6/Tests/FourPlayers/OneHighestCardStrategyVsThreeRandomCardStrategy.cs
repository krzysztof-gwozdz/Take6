namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneHighestCardStrategyVsThreeRandomCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Highest", new PlayHighestCardStrategy()),
            new Player("Random 1", new PlayRandomCardStrategy()),
            new Player("Random 2", new PlayRandomCardStrategy()),
            new Player("Random 3", new PlayRandomCardStrategy())
        };
    }
}