namespace Take6;

interface IPlayCardStrategy
{
    ushort PlayCard(Player player, CardRow[] cardRows);
}

internal class PlayRandomCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.RandomCard;
}

internal class PlayHighestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.HighestCard;
}

internal class PlayLowestCardStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows) => player.Hand.LowestCard;
}

internal class PlayCardWithLowestDifferenceStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows)
    {
        var cardToPlay = player.Hand.RandomCard;
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

internal class PlayCardWithLowestDifferenceAndAvoidFullRowsStrategy : IPlayCardStrategy
{
    public ushort PlayCard(Player player, CardRow[] cardRows)
    {
        var cardToPlay = player.Hand.RandomCard;
        var lastCardValues = cardRows.Where(cardRow => !cardRow.ItsFull).Select(cardRow => cardRow.LastCard).ToHashSet();
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