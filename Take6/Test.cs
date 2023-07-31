namespace Take6;

internal abstract class Test
{
    private const long NumberOfGames = 10000;

    public void Run()
    {
        PrintTestName();
        var players = GetPlayers();
        Play(players);
        PrintPlayersStats(players);
    }
    
    protected abstract Player[] GetPlayers();
    
    private static void PrintTestName() => Console.WriteLine(new System.Diagnostics.StackTrace().GetFrame(1)?.GetMethod()?.Name);

    private static void Play(Player[] players)
    {
        for (var i = 0; i < NumberOfGames; i++)
            new Game(players).Play();
    }

    private static void PrintPlayersStats(Player[] players)
    {
        foreach (var player in players)
            Console.WriteLine($"{player.Name} {player.Wins * 100.0 / NumberOfGames}% {player.GameResults.Average(gameResult => gameResult.Points):##.##}");
    }
}