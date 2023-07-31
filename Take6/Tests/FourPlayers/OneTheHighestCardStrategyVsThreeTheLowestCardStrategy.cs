﻿namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneTheHighestCardStrategyVsThreeTheLowestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("The Highest", new PlayTheHighestCardStrategy()),
            new Player("The Lowest 1", new PlayTheLowestCardStrategy()),
            new Player("The Lowest 2", new PlayTheLowestCardStrategy()),
            new Player("The Lowest 3", new PlayTheLowestCardStrategy())
        };
    }
}