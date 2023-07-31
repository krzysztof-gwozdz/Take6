namespace Take6;

internal class CardRow : List<Card>
{
    public Card LastCard => this.Last();

    public CardRow(params Card[] cards) :base(cards.OrderBy(card => card.Value))
    {
    }
    
    public Card Random() => this.OrderBy(_ => Guid.NewGuid()).First();
    
    public Card Highest() => this.OrderBy(card => card.Value).Last();
    
    public Card Lowest() => this.OrderBy(card => card.Value).First();
}