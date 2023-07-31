using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Take6;

internal abstract class Test
{
    private const long NumberOfGames = 10000;

    public void Run()
    {
        PrintTestName();
        var players = GetPlayers();
        var stopwatch = Stopwatch.StartNew();
        Play(players);
        stopwatch.Stop();
        PrintTimeInfo(stopwatch);
        PrintPlayersStats(players);
    }

    protected abstract Player[] GetPlayers();

    private void PrintTestName()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(Environment.NewLine + ToSentenceCase(GetType().Name));
        Console.ResetColor();
    }

    private static void Play(Player[] players)
    {
        for (var i = 0; i < NumberOfGames; i++)
            new Game(players).Play();
    }

    private void PrintTimeInfo(Stopwatch stopwatch)
    {
        Console.WriteLine($" [{stopwatch.ElapsedMilliseconds} ms]");
        Console.ResetColor();
    }

    private static void PrintPlayersStats(Player[] players)
    {
        const double tolerance = 2.5;
        var maxWins = players.Max(player => player.Wins) * 100.0 / NumberOfGames;
        foreach (var player in players)
        {
            var winsPercentage = player.Wins * 100.0 / NumberOfGames;
            if (winsPercentage > maxWins - tolerance)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            Console.WriteLine($"{player.Name} {winsPercentage}% {player.GameResults.Average(gameResult => gameResult.Points):##.##}");
            Console.ResetColor();
        }
    }

    private static string ToSentenceCase(string str) => 
        Regex.Replace(str, "[a-z][A-Z]", m => m.Value[0] + " " + char.ToLower(m.Value[1]));
}