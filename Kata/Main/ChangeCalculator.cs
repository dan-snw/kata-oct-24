namespace Kata;

public static class ChangeCalculator
{
    public static int[] GetChange(int changeNeeded, int[] denominations)
    {
        var returnList = new List<int>();
        foreach (int coin in denominations.Reverse())
        {
            returnList.Add(changeNeeded / coin);
            changeNeeded %= coin;
        }
        returnList.Reverse();
        return returnList.ToArray();
    }
}
