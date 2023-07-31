namespace Take6;

internal class Game
{
    private string Name { get; }
    private readonly Player[] _players;
    private readonly CardRow[] _rows;
    private CardRow _playedCards;
    private uint _tour;

    public Game(string name, Player[] players)
    {
        Name = name;
        _players = players;
        _rows = Enumerable.Range(0, 4).Select(_ => new CardRow()).ToArray();
        _playedCards = new CardRow();
    }

    public void Play()
    {
        do
        {
            SetupRound();
            do
            {
                _tour++;
                var cardWithPlayers = _players.Select(player => (card: player.PlayACard(), player)).ToArray();
                _playedCards = new CardRow(cardWithPlayers.Select(cardWithPlayer => cardWithPlayer.card).ToArray());
                foreach (var cardWithPlayer in cardWithPlayers)
                {
                    var (card, player) = cardWithPlayer;
                    var cardRow = _rows.Where(row => row.LastCard.Value < cardWithPlayer.card.Value).MaxBy(row => row.LastCard.Value);
                    if (cardRow is null)
                    {
                        cardRow = player.ChooseCardRowToTake(_rows);
                        player.TakeCardRow(cardRow);
                    }

                    if (cardRow.Count == 5)
                    {
                        player.TakeCardRow(cardRow);
                    }

                    cardRow.Add(card);
                    _playedCards.Remove(card);
                }
            } while (_tour < 10);
        } while (!_players.Any(player => player.Lost));
        Display();
    }

    private void SetupRound()
    {
        _tour = 0;
        var cards = Cards.FullSet().Shuffle();
        foreach (var row in _rows)
        {
            row.Clear();
            row.Add(cards[0]);
            cards.RemoveAt(0);
        }

        foreach (var player in _players)
        {
            player.SetNewHand(new(cards.Take(10).ToArray()));
            cards.RemoveRange(0, 10);
        }
    }

    private void Display()
    {
        Console.Clear();
        Console.WriteLine($"Game: {Name}");
        foreach (var player in _players)
        {
            Console.Write($"{player.Name} [{player.Points}] ");
            DisplayCardRow(player.Hand);
            Console.Write(Environment.NewLine);
        }

        Console.Write(Environment.NewLine);
        foreach (var row in _rows)
        {
            DisplayCardRow(row);
            Console.Write(Environment.NewLine);
        }

        Console.Write(Environment.NewLine);
        DisplayCardRow(_playedCards);
        Console.Write(Environment.NewLine);

        void DisplayCardRow(CardRow cardRow)
        {
            foreach (var card in cardRow)
            {
                DisplayCard(card);
                Console.Write(" ");
            }
        }

        void DisplayCard(Card card)
        {
            if (card.Value == 55)
                Console.ForegroundColor = ConsoleColor.Red;
            else if (card.Value % 11 == 0)
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (card.Value % 10 == 0)
                Console.ForegroundColor = ConsoleColor.Green;
            else if (card.Value % 5 == 0)
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"[{card.Value:###}]");
            Console.ResetColor();
        }
    }
}