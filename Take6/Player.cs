namespace Take6;

internal class Player
{
    public string Name { get; }
    public CardRow Hand { get; private set; }
    public int Points { get; private set; }

    public List<GameResult> GameResults { get; }
    
    public int Wins => GameResults.Count(gameResult => gameResult.Won);

    public int Losses => GameResults.Count(gameResult => !gameResult.Won); 
        
    public Player(string name)
    {
        Name = name;
        Hand = new CardRow();   
        ResetPoints();
        GameResults = new List<GameResult>();
    }

    public void ResetPoints() => Points = 66;

    public void SetNewHand(CardRow cards) => Hand = cards;

    public Card PlayACard() => Hand.TakeLastCard();

    public CardRow ChooseCardRowToTake(CardRow[] cardRows) => cardRows[0];
    
    public void AddGameResult(bool won) => GameResults.Add(new GameResult(won, Points));    

    public void TakeCardRow(CardRow cardRow)
    {
        Points -= cardRow.Sum(card => card.Points);
        cardRow.Clear();
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