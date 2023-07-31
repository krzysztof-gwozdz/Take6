namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class TwoTheHighestCardStrategyVsTwoTheLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Player 1 - The Highest", new PlayTheHighestCardStrategy()),
            new Player("Player 2 - The Highest", new PlayTheHighestCardStrategy()),
            new Player("Player 3 - The Lowest", new PlayTheLowestCardStrategy()),
            new Player("Player 4 - The Lowest", new PlayTheLowestCardStrategy())
        };
    }
}