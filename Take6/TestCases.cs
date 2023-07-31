using Take6.Tests.FourPlayers;

namespace Take6;

public static class TestCases
{
    public static void All()
    {
        var tests = new Test[]
        {
            new FourPlayersTest.RandomStrategy(),
            new FourPlayersTest.FourTheHighestCardStrategy(),
            new FourPlayersTest.FourTheLowestCardStrategy(),
            new FourPlayersTest.TwoTheHighestCardStrategyVsTwoTheLowestCardStrategy(),
            new FourPlayersTest.OneTheHighestCardStrategyVsThreeTheLowestCardStrategy(),
            new FourPlayersTest.OneTheLowestCardStrategyVsThreeTheHighestCardStrategy(),
            new FourPlayersTest.OneTheHighestCardStrategyVsThreeRandomCardStrategy(),
            new FourPlayersTest.OneTheLowestCardStrategyVsThreeRandomCardStrategy(),
        };
        foreach (var test in tests)
            test.Run();
    }
}