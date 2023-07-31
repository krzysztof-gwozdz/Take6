namespace Take6;

public static class Program
{
    public static void Main()
    {
        var players = Enumerable.Range(0, 4).Select(x => new Player($"Player {x}")).ToArray();
        new Game(players).Play();
    }
}