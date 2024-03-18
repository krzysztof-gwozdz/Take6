using Take6.Strategies;

namespace Take6.Tests;

internal class TwoPlayersCombinationsTest
{
    private const long NumberOfTests = 1000;
    
    private readonly Player[] _players1 =
    {
        new("Random 1", new PlayRandomCardStrategy()),
        new("Highest 1", new PlayHighestCardStrategy()),
        new("Lowest 1", new PlayLowestCardStrategy()),
        new("Lowest Difference 1", new PlayCardWithLowestDifferenceStrategy()),
        new("Lowest Difference And Avoid Full Rows 1", new PlayCardWithLowestDifferenceAndAvoidFullRowsStrategy()),
        new("Highest And Lowest Alternately 1", new PlayHighestAndLowestCardAlternatelyStrategy()),
        new("Middle 1", new PlayMiddleCardStrategy()),
        new("Combination 2H4M6L 1", new Play2Highest4MiddleAnd6LowestCardStrategy())
    };

    private readonly Player[] _players2 =
    {
        new("Random 2", new PlayRandomCardStrategy()),
        new("Highest 2", new PlayHighestCardStrategy()),
        new("Lowest 2", new PlayLowestCardStrategy()),
        new("Lowest Difference 2", new PlayCardWithLowestDifferenceStrategy()),
        new("Lowest Difference And Avoid Full Rows 2", new PlayCardWithLowestDifferenceAndAvoidFullRowsStrategy()),
        new("Highest And Lowest Alternately 2", new PlayHighestAndLowestCardAlternatelyStrategy()),
        new("Middle 2", new PlayMiddleCardStrategy()),
        new("Combination 2H4M6L 2", new Play2Highest4MiddleAnd6LowestCardStrategy())
    };

    private IEnumerable<Player> AllPlayers => _players1.Concat(_players2);

    private readonly (Player player1, Player player2)[] _playersCombinations;

    public TwoPlayersCombinationsTest()
    {
        _playersCombinations = _players1.SelectMany(_ => _players2, (player1, player2) => (player1, player2)).ToArray();
    }

    public void Run()
    {
        Test();
        DisplayResults();
    }

    private void Test()
    {
        foreach (var (player1, player2) in _playersCombinations)
            for (var i = 0; i < NumberOfTests; i++)
                new Game(new[] { player1, player2 }).Play();
    }

    private void DisplayResults()
    {
        var numberOfGames = AllPlayers.First().GameResults.Count * 2;
        Console.WriteLine($"Results for 2 players after {numberOfGames} games: ");
        Console.WriteLine($"| {"Player",-40} | {"Wins",-6} | {"Avg",-6} | {"Min",-3} | {"Max",-3} |");
        var players = AllPlayers.GroupBy(player => player.Name.Remove(player.Name.Length - 2, 2)).Select(group => (Name: group.Key, GameResults: group.SelectMany(player => player.GameResults)));
        foreach (var player in players.OrderByDescending(player => player.GameResults.Count(result => result.Won)))
        {
            var winsPercentage = (double)player.GameResults.Count(result => result.Won) / numberOfGames;
            Console.WriteLine($"| {player.Name,-40} | {winsPercentage:00.00%} | {player.GameResults.Average(gameResult => gameResult.Points):+00.00;-00.00} | {player.GameResults.Min(gameResult => gameResult.Points):+00;-00} | {player.GameResults.Max(gameResult => gameResult.Points):+00;-00} |");
            Console.ResetColor();
        }
    }
}