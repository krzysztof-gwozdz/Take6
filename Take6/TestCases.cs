using Take6.Tests.FourPlayers;

namespace Take6;

public static class TestCases
{
    public static void All()
    {
        var tests = new Test[]
        {
            new FourPlayersTest.RandomStrategy(),
            new FourPlayersTest.FourHighestCardStrategy(),
            new FourPlayersTest.FourLowestCardStrategy(),
            new FourPlayersTest.TwoHighestCardStrategyVsTwoLowestCardStrategy(),
            new FourPlayersTest.OneHighestCardStrategyVsThreeLowestCardStrategy(),
            new FourPlayersTest.OneLowestCardStrategyVsThreeHighestCardStrategy(),
            new FourPlayersTest.OneHighestCardStrategyVsThreeRandomCardStrategy(),
            new FourPlayersTest.OneLowestCardStrategyVsThreeRandomCardStrategy(),
        };
        foreach (var test in tests)
            test.Run();
    }
}