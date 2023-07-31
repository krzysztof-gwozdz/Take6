namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class MixStrategy1 : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Lowest Difference", new PlayCardWithLowestDifferenceStrategy()),
            new Player("Lowest Difference +", new PlayCardWithLowestDifferenceAndAvoidFullRowsStrategy()),
            new Player("Highest", new PlayHighestCardStrategy()),
            new Player("Lowest", new PlayLowestCardStrategy()),
        };
    }
}