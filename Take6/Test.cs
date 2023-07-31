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
    
    private void PrintTestName() => Console.WriteLine(Environment.NewLine + GetType().Name);

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