namespace Take6.Strategies;

internal class PlayHighestAndLowestCardAlternatelyStrategy : IPlayCardStrategy
{
    private bool _playHighestCard = true;

    public ushort PlayCard(Player player, CardRow[] cardRows)
    {
        var cardToPlay = _playHighestCard ? player.Hand.HighestCard : player.Hand.LowestCard;
        _playHighestCard = !_playHighestCard;
        return cardToPlay;
    }
}