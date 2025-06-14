// BitPlusPlus.SolveProblem();

public static class BitPlusPlus
{
    public static void SolveProblem()
    {
        IEnumerable<string> lines = GetLines();
        int finalValueOfX = lines.Sum(ValueOfX);
        Console.WriteLine(finalValueOfX);
    }

    private static int ValueOfX(string statement)
    {
        switch (statement)
        {
            case "X++":
            case "++X":
                return 1;
            case "X--":
            case "--X":
                return -1;
            default:
                throw new Exception("Illegal state");
        }
    }



    private static IEnumerable<string> GetLines()
    {

        string? line = Console.In.ReadLine();
        ArgumentNullException.ThrowIfNull(line);
        int lineCount = int.Parse(line);

        for (int i = 0; i < lineCount; i++)
        {
            line = Console.In.ReadLine();
            ArgumentNullException.ThrowIfNull(line);
            yield return line;
        }
    }


}