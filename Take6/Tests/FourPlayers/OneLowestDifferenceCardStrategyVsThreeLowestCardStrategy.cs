using Take6.Strategies;

namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class LowestDifferenceCardStrategyVsThreeLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Lowest Difference", new PlayCardWithLowestDifferenceStrategy()),
            new Player("Random 1", new PlayRandomCardStrategy()),
            new Player("Random 2", new PlayRandomCardStrategy()),
            new Player("Random 3", new PlayRandomCardStrategy())
        };
    }
}