using Take6.Tests.FourPlayers;

namespace Take6;

public static class TestCases
{
    public static void All()
    {
        Run(new Test[]
        {
            new FourPlayersTest.RandomStrategy(),
            new FourPlayersTest.FourHighestCardStrategy(),
            new FourPlayersTest.FourLowestCardStrategy(),
            new FourPlayersTest.TwoHighestCardStrategyVsTwoLowestCardStrategy(),
            new FourPlayersTest.OneHighestCardStrategyVsThreeLowestCardStrategy(),
            new FourPlayersTest.OneLowestCardStrategyVsThreeHighestCardStrategy(),
            new FourPlayersTest.OneHighestCardStrategyVsThreeRandomCardStrategy(),
            new FourPlayersTest.OneLowestCardStrategyVsThreeRandomCardStrategy(),
            new FourPlayersTest.LowestDifferenceCardStrategyVsThreeLowestCardStrategy()
        });
    }

    public static void LowestDifference()
    {
        Run(new Test[]
        {
            new FourPlayersTest.LowestDifferenceCardStrategyVsThreeLowestCardStrategy(),
            new FourPlayersTest.OneLowestDifferenceAndAvoidFullRowsCardStrategyVsThreeLowestCardStrategy()
        });
    }
    
    public static void Mixes()
    {
        Run(new Test[]
        {
            new FourPlayersTest.MixStrategy1()
        });
    }

    private static void Run(Test[] tests)
    {
        foreach (var test in tests)
            test.Run();
    }
}