namespace Take6;

internal class CardRow : List<ushort>
{
    public CardRow(params ushort[] cards) : base(cards.OrderBy(card => card))
    {
    }

    public ushort LastCard => this.Last();
    public ushort Random => this.MinBy(_ => Guid.NewGuid());

    public ushort Highest => this.MaxBy(card => card);

    public ushort Lowest => this.MinBy(card => card);
}