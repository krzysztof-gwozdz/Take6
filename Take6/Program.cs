using System.Diagnostics;

namespace Take6;

public static class Program
{
    public static void Main()
    {
        var stopwatch = Stopwatch.StartNew();
        TestCases.LowestDifference();
        stopwatch.Stop();
        PrintTimeInfo(stopwatch);
    }

    private static void PrintTimeInfo(Stopwatch stopwatch)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{Environment.NewLine}All tests take: {stopwatch.ElapsedMilliseconds} ms");
        Console.ResetColor();
    }
}