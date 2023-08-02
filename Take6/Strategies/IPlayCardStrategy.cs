namespace Take6.Strategies;

interface IPlayCardStrategy
{
    ushort PlayCard(Player player, CardRow[] cardRows);
}