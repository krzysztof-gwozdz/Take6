namespace Take6;

internal class Tests
{
    private const long NumberOfGames = 10000;

    public static void BaseTest()
    {
        Console.WriteLine("Base test");
        var players = Enumerable.Range(0, 4).Select(x => new Player($"Player {x}")).ToArray();
        for (var i = 0; i < NumberOfGames; i++)
            new Game(players).Play();
        foreach (var player in players)
            Console.WriteLine($"{player.Name} {player.Wins * 100.0 / NumberOfGames}% {player.GameResults.Average(gameResult => gameResult.Points):##.##}");
    }
}