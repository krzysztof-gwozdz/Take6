using Take6.Strategies;

namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneLowestCardStrategyVsThreeRandomCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Lowest", new PlayLowestCardStrategy()),
            new Player("Random 1", new PlayRandomCardStrategy()),
            new Player("Random 2", new PlayRandomCardStrategy()),
            new Player("Random 3", new PlayRandomCardStrategy())
        };
    }
}