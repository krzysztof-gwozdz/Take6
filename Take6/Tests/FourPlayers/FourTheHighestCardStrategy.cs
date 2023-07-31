namespace Take6.Tests.FourPlayers;

internal partial class FourPlayersTest
{
    internal class FourTheHighestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Player 1", new PlayTheHighestCardStrategy()),
            new Player("Player 2", new PlayTheHighestCardStrategy()),
            new Player("Player 3", new PlayTheHighestCardStrategy()),
            new Player("Player 4", new PlayTheHighestCardStrategy())
        };
    }
}