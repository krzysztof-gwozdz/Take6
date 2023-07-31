namespace Take6;

internal class CardRow : List<ushort>
{
    public CardRow(params ushort[] cards) : base(cards.OrderBy(card => card))
    {
    }

    public ushort LastCard => this.Last();

    public ushort RandomCard => this.MinBy(_ => Guid.NewGuid());

    public ushort HighestCard => this.MaxBy(card => card);

    public ushort LowestCard => this.MinBy(card => card);
    public bool ItsFull => Count == 5;
}