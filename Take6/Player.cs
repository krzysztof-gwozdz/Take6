namespace Take6;

internal class Player
{
    private readonly IPlayCardStrategy _playCardStrategy;
    public string Name { get; }
    public CardRow Hand { get; private set; }
    public int Points { get; private set; }

    public List<GameResult> GameResults { get; }
    
    public int Wins => GameResults.Count(gameResult => gameResult.Won);

    public int Losses => GameResults.Count(gameResult => !gameResult.Won); 
        
    public Player(string name, IPlayCardStrategy playCardStrategy)
    {
        _playCardStrategy = playCardStrategy;
        Name = name;
        Hand = new CardRow();   
        ResetPoints();
        GameResults = new List<GameResult>();
    }

    public void ResetPoints() => Points = 66;

    public void SetNewHand(CardRow cards) => Hand = cards;

    public ushort PlayCard(CardRow[] cardRows)
    {
        var card = _playCardStrategy.PlayCard(this, cardRows);
        Hand.Remove(card);
        return card;
    }

    public CardRow ChooseCardRowToTake(CardRow[] cardRows) => cardRows[0];
    
    public void AddGameResult(bool won) => GameResults.Add(new GameResult(won, Points));    

    public void TakeCardRow(CardRow cardRow)
    {
        Points -= cardRow.Sum(card => GetPointsForCard(card));
        cardRow.Clear();
    }
    
    private static ushort GetPointsForCard(ushort card)
{
        if (card == 55)
            return 7;
        if (card % 11 == 0)
            return 5;
        if (card % 10 == 0)
            return 3;
        if (card % 5 == 0)
            return 2;
        return 1;
    }
    
}

internal class GameResult
{
    public bool Won { get; }
    public int Points { get; }

    public GameResult(bool won, int points)
    {
        Won = won;
        Points = points;
    }
}