namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, int[] denominations)
    {
        var reversedDenominations = denominations.Reverse().ToArray();
        var returnList = new List<int>();
        foreach (int coin in reversedDenominations)
        {
            var numberOfThisCoinNeeded = changeNeeded / coin;
            returnList.Add(numberOfThisCoinNeeded);
            changeNeeded %= coin;
        }
        returnList.Reverse();
        return returnList;
    }
}
