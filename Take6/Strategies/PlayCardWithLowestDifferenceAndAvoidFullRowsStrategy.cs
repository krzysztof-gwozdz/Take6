namespace Take6.Strategies;

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