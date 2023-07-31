namespace Take6.Tests.FourPlayers;

internal partial class FourPlayersTest
{
    internal class FourTheLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Player 1", new PlayTheLowestCardStrategy()),
            new Player("Player 2", new PlayTheLowestCardStrategy()),
            new Player("Player 3", new PlayTheLowestCardStrategy()),
            new Player("Player 4", new PlayTheLowestCardStrategy())
        };
    }
}