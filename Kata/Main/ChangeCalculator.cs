namespace Kata;

public static class ChangeCalculator
{
    public static int[] GetChange(int changeNeeded, int[] denominations)
    {
        if (denominations.Length == 1)
        {
            return [changeNeeded / denominations[0]];
        }
        var returnList = new List<int>();
        returnList.AddRange(GetChange(changeNeeded % denominations[^1], denominations.Take(denominations.Length - 1).ToArray()));
        returnList.Add(changeNeeded / denominations[^1]);
        return returnList.ToArray();
    }
}
