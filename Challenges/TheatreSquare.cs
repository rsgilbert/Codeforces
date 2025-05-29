namespace Codeforces.Challenges;

// TheatreSquare.SolveProblem();

/// <summary>
/// see: https://codeforces.com/problemset/problem/1/A
/// </summary>
public static class TheatreSquare
{

    public static void SolveProblem()
    {
        List<int> lineInts = GetLineInts();
        long minimumNumberOfFlagstones = CalculateMinimumNumberOfFlagstones(lineInts[0], lineInts[1], lineInts[2]);
        Console.WriteLine(minimumNumberOfFlagstones);
    }


    public static long CalculateMinimumNumberOfFlagstones(
        int theatreWidth,
        int theaterLength,
        int flagStoneWidth
    )
    {
        decimal flagstonesOnWidth = theatreWidth / (decimal)flagStoneWidth;
        decimal minimumFlagstonesOnWidth = Math.Ceiling(flagstonesOnWidth);
        decimal flagstonesOnLength = theaterLength / (decimal)flagStoneWidth;
        decimal minimumFlagstonesOnLength = Math.Ceiling(flagstonesOnLength);
        decimal minimumFlagstones = minimumFlagstonesOnLength * minimumFlagstonesOnWidth;
        long result = (long)minimumFlagstones;
        return result;
    }



    private static List<int> GetLineInts()
    {

        string? line = Console.In.ReadLine();
        ArgumentNullException.ThrowIfNull(line);
        return line.Split(" ").Select(e => int.Parse(e)).ToList();
    }
}
