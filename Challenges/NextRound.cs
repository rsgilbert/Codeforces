namespace Codeforces.Challenges;

// NextRound.SolveProblem();

/// <summary>
/// https://codeforces.com/problemset/problem/158/A
/// </summary>
public static class NextRound
{

    public static void SolveProblem()
    {
        var nAndK = GetNAndK();
        var n = nAndK[0];
        var k = nAndK[1];

        List<int> lineInts = GetLineInts();
        var minimum = Math.Max(lineInts[k -1], 1);
        lineInts = lineInts.Where(lineInt=> lineInt >= minimum).ToList();

        int count = lineInts.Count();
        Console.WriteLine(count);
    }



    private static List<int> GetNAndK()
    {

        string? line = Console.In.ReadLine();
        ArgumentNullException.ThrowIfNull(line);
        var list = line.Split(" ").Select(e => int.Parse(e)).ToList();
        return list;
    }


    private static List<int> GetLineInts()
    {

        string? line = Console.In.ReadLine();
        ArgumentNullException.ThrowIfNull(line);
        return line.Split(" ").Select(e => int.Parse(e)).ToList();
    }
}
