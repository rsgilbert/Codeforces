using System.Collections.Immutable;

// LongWords.SolveProblem();


/// <summary>
/// see: https://codeforces.com/problemset/problem/71/A
/// </summary>
public static class LongWords
{

    public static void SolveProblem()
    {
        List<string> lines = GetLines();
        foreach (string line in lines)
        {
            string shortForm = Abbreviate(line);
            Console.WriteLine(shortForm);
        }
    }

    private static string Abbreviate(string word)
    {
        if (word.Length <= 10)
        {
            return word;
        }
        string result = $"{word[0]}{word.Length - 2}{word[^1]}";
        return result;
    }

    private static List<string> GetLines()
    {

        string? line = Console.In.ReadLine();
        ArgumentNullException.ThrowIfNull(line);
        int lineCount = int.Parse(line);

        return Enumerable.Range(0, lineCount).ToImmutableArray().Select(_i =>
        {
            string? line = Console.In.ReadLine();
            ArgumentNullException.ThrowIfNull(line);
            return line;
        }).ToList();
    }
}
