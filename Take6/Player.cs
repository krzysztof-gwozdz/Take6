namespace Take6;

internal class Player
{
    public string Name { get; }
    public CardRow Hand { get; private set; }
    public int Points { get; private set; }
    
    public int Wins = 0;

    public int Losses = 0;

    public Player(string name)
    {
        Name = name;
        Hand = new CardRow();   
        ResetPoints();
    }

    public void ResetPoints() => Points = 66;

    public void SetNewHand(CardRow cards) => Hand = cards;

    public Card PlayACard() => Hand.TakeLastCard();

    public CardRow ChooseCardRowToTake(CardRow[] cardRows) => cardRows[0];

    public void TakeCardRow(CardRow cardRow)
    {
        Points -= cardRow.Sum(card => card.Points);
        cardRow.Clear();
    }
}