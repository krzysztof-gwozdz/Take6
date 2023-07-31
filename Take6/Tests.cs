namespace Take6;

internal class Tests
{
    private const long NumberOfGames = 10000;

    public static void BaseTest()
    {
        PrintTestName();
        var players = Enumerable.Range(0, 4).Select(x => new Player($"Player {x}", new PlayRandomCardStrategy())).ToArray();
        Play(players);
        PrintPlayersStats(players);
    }
    
    public static void FourPlayersTest_TheHighestCardStrategy()
    {
        PrintTestName();
        var players = new[]
        {
            new Player("Player 1", new PlayTheHighestCardStrategy()),
            new Player("Player 2", new PlayTheHighestCardStrategy()),
            new Player("Player 3", new PlayTheHighestCardStrategy()),
            new Player("Player 4", new PlayTheHighestCardStrategy())
        };
        Play(players);
        PrintPlayersStats(players);
    }
    
    public static void FourPlayersTest_TwoTheLowestCardStrategy()
    {
        PrintTestName();
        var players = new[]
        {
            new Player("Player 1", new PlayTheLowestCardStrategy()),
            new Player("Player 2", new PlayTheLowestCardStrategy()),
            new Player("Player 3", new PlayTheLowestCardStrategy()),
            new Player("Player 4", new PlayTheLowestCardStrategy())
        };
        Play(players);
        PrintPlayersStats(players);
    }

    public static void FourPlayersTest_TwoTheHighestCardStrategy_vs_TwoTheLowestCardStrategy()
    {
        PrintTestName();
        var players = new[]
        {
            new Player("Player 1 - TheHighest", new PlayTheHighestCardStrategy()),
            new Player("Player 2 - TheHighest", new PlayTheHighestCardStrategy()),
            new Player("Player 3 - TheLowest", new PlayTheLowestCardStrategy()),
            new Player("Player 4 - TheLowest", new PlayTheLowestCardStrategy())
        };
        Play(players);
        PrintPlayersStats(players);
    }

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