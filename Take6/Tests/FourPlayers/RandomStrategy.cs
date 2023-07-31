namespace Take6.Tests.FourPlayers;

internal partial class FourPlayersTest
{
    internal class RandomStrategy : Test
    {
        protected override Player[] GetPlayers() => Enumerable.Range(0, 4).Select(x => new Player($"Player {x}", new PlayRandomCardStrategy())).ToArray();
    }
}