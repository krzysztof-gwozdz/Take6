using Take6.Tests.FourPlayers;

namespace Take6;

public static class Program
{
    public static void Main()
    { 
        new FourPlayersTest.RandomStrategy().Run();
        new FourPlayersTest.FourTheHighestCardStrategy().Run();
        new FourPlayersTest.FourTheLowestCardStrategy().Run();
        new FourPlayersTest.TwoTheHighestCardStrategyVsTwoTheLowestCardStrategy().Run();
    }
}