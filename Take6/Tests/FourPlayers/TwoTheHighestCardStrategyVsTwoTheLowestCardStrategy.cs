namespace Take6.Tests.FourPlayers;

internal partial class FourPlayersTest
{
    internal class TwoTheHighestCardStrategyVsTwoTheLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Player 1 - TheHighest", new PlayTheHighestCardStrategy()),
            new Player("Player 2 - TheHighest", new PlayTheHighestCardStrategy()),
            new Player("Player 3 - TheLowest", new PlayTheLowestCardStrategy()),
            new Player("Player 4 - TheLowest", new PlayTheLowestCardStrategy())
        };
    }
}