// ATeam.SolveProblem();

/// <summary>
/// see: https://codeforces.com/problemset/problem/231/A
/// </summary>
public static class ATeam
{
    public static void SolveProblem()
    {
        IEnumerable<string> lines = GetLines();
        int implementableProblems = lines.Count(WillImplement);
        Console.WriteLine(implementableProblems);
    }

    private static bool WillImplement(string assurance)
    {
        string[] individualAssurances = assurance.Split(" ");
        int positiveAssuranceCount = individualAssurances.Count(ind => ind == "1");
        return positiveAssuranceCount >= 2;
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