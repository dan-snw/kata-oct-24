namespace Kata;

public static class ChangeCalculator
{
    public static int[] GetChange(int changeNeeded, int[] denominations) =>
        denominations.Length == 1 
            ? [changeNeeded / denominations[0]] 
            : GetChange(changeNeeded % denominations[^1], denominations.Take(denominations.Length - 1).ToArray())
                .Concat([changeNeeded / denominations[^1]])
                .ToArray();
}
