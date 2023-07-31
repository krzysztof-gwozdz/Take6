namespace Take6;

internal class Cards : List<ushort>
{
    private static readonly ushort[] AllCards = Enumerable.Range(1, 104).Select(i => (ushort) i).ToArray();
 
    private Cards(params ushort[] cards) : base(cards)
    {
    }

    public static Cards FullSet() => new(AllCards);
    
    public Cards Shuffle() => new(this.OrderBy(card => Guid.NewGuid()).ToArray());
}