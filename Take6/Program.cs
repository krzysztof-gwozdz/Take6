using System.Diagnostics;
using Take6.Tests;

namespace Take6;

public static class Program
{
    public static void Main()
    {
        var me = 223.74;
        var player2 = 265;
        var player3 = 165;
        var player4 = 1;

        var chanceToWinWithPlayer2 = ExpectationToWin(me, player2);
        var chanceToWinWithPlayer3 = ExpectationToWin(me, player3);
        var chanceToWinWithPlayer4 = ExpectationToWin(me, player4);
        
        var elo1 = CalculateELO(me, player4, GameOutcome.Loss);
        var elo2 = CalculateELO(me, player3, GameOutcome.Win);
        var elo3 = CalculateELO(me, player2, GameOutcome.Win);

        var stopwatch = Stopwatch.StartNew();
        new TwoPlayersCombinationsTest().Run();
        Console.WriteLine();
        new ThreePlayersCombinationsTest().Run();
        Console.WriteLine();
        new FourPlayersCombinationsTest().Run();
        stopwatch.Stop();
        PrintTimeInfo(stopwatch);
    }

    private static void PrintTimeInfo(Stopwatch stopwatch)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{Environment.NewLine}All tests take: {stopwatch.ElapsedMilliseconds} ms");
        Console.ResetColor();
    }

    static double ExpectationToWin(double playerOneRating, double playerTwoRating)
    {
        return 1 / (1 + Math.Pow(10, (playerTwoRating - playerOneRating) / 400.0));
    }

    enum GameOutcome
    {
        Win = 1,
        Loss = 0
    }

    static double CalculateELO(double playerOneRating, double playerTwoRating, GameOutcome outcome)
    {
        const int k = 13;
        return k * ((int)outcome - ExpectationToWin(playerOneRating, playerTwoRating));
    }
}