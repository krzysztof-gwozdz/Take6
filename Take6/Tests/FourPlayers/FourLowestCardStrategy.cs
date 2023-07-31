namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class FourLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Lowest 1", new PlayLowestCardStrategy()),
            new Player("Lowest 2", new PlayLowestCardStrategy()),
            new Player("Lowest 3", new PlayLowestCardStrategy()),
            new Player("Lowest 4", new PlayLowestCardStrategy())
        };
    }
}