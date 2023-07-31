namespace Take6;

interface IPlayCardStrategy
{
    ushort PlayCard(Player player, CardRow[] cardRows);
}

internal class PlayRandomCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.Random;
}

internal class PlayHighestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.Highest;
}

internal class PlayLowestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.Lowest;
}

internal class PlayCardWithLowestDifferenceStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows)
    {
        var cardToPlay = player.Hand.Random;
        var lastCardValues = cardRows.Select(cardRow => cardRow.LastCard).ToHashSet();
        var smallestDifference = 103;
        var cards = player.Hand.Where(cardFromHand => lastCardValues.Any(cardFromRow => cardFromRow < cardFromHand));
        foreach (var card in cards)
        {
            var difference = lastCardValues.Min(cardFromRow => Math.Abs(cardFromRow - card));
            if (difference < smallestDifference)
            {
                smallestDifference = difference;
                cardToPlay = card;
            }
        }

        return cardToPlay;
    }
}