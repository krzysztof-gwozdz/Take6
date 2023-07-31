namespace Take6;

interface IPlayCardStrategy
{
    Card PlayCard(Player player, CardRow[] cardRows);
}

internal class PlayRandomCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Random;
}

internal class PlayHighestCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Highest;
}

internal class PlayLowestCardStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows) => player.Hand.Lowest;
}

internal class PlayCardWithLowestDifferenceStrategy : IPlayCardStrategy
{
    public Card PlayCard(Player player, CardRow[] cardRows)
    {
        var cardToPlay = player.Hand.Random;
        var lastCardValues = cardRows.Select(cardRow => cardRow.LastCard.Value).ToHashSet();
        var smallestDifference = 103;
        var cards = player.Hand.Where(cardFromHand => lastCardValues.Any(cardFromRow => cardFromRow < cardFromHand.Value));
        foreach (var card in cards)
        {
            var difference = lastCardValues.Min(cardFromRow => Math.Abs(cardFromRow - card.Value));
            if (difference < smallestDifference)
            {
                smallestDifference = difference;
                cardToPlay = card;
            }
        }

        return cardToPlay;
    }
}