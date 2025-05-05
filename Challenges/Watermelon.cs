// Watermelon.SolveProblem();

/// <summary>
///  See: https://codeforces.com/problemset/problem/4/A
/// </summary>
public static class Watermelon 
{
    public static void SolveProblem()
    {
        string? line = Console.In.ReadLine();        
        ArgumentNullException.ThrowIfNull(line);
        int weight = int.Parse(line);
        string output = CanDivide(weight) ? "YES" : "NO";
        Console.WriteLine(output);
    }

    private static bool CanDivide(int amount)
    {
        int secondPortion = amount - 2;
        bool secondPortionIsEven = secondPortion % 2 == 0;
        bool secondPortionIsPositive = secondPortion > 0;
        return secondPortionIsEven && secondPortionIsPositive;
    }
}
