namespace Take6;

interface IPlayACardStrategy
{
    Card PlayACard(Player player, CardRow[] cardRows);
}