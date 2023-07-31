namespace Take6;

internal class CardRow : List<Card>
{
    public Card LastCard => this.Last();

    public CardRow(params Card[] cards) :base(cards.OrderBy(card => card.Value))
    {
    }

    public Card TakeLastCard()
    {
        var card = LastCard;
        Remove(card);
        return card;
    }
}