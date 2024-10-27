namespace Kata;

public static class ChangeCalculator
{
    public static int[] GetChange(int changeNeeded, int[] denominations) =>
        denominations.Length == 1 
            ? [changeNeeded / denominations[0]] 
            : GetChange(changeNeeded % denominations[^1], denominations[..^1])
                .Concat([changeNeeded / denominations[^1]])
                .ToArray();
}
