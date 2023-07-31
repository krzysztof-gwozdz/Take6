﻿namespace Take6.Tests.FourPlayers;

internal abstract partial class FourPlayersTest
{
    internal class OneLowestCardStrategyVsThreeHighestCardStrategy : Test
    {
        protected override Player[] GetPlayers() => new[]
        {
            new Player("Lowest", new PlayLowestCardStrategy()),
            new Player("Highest 1", new PlayHighestCardStrategy()),
            new Player("Highest 2", new PlayHighestCardStrategy()),
            new Player("Highest 3", new PlayHighestCardStrategy())
        };
    }
}