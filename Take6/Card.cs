namespace Take6;

internal class Card
{
    public int Value { get; }
    public int Points { get; }

    public Card(int value, int points)
    {
        Value = value;
        Points = points;
    }
}