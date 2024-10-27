namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, int[] denominations)
    {
        var reversedDenominations = denominations.Reverse().ToArray();
        var returnList = new List<int>();
        for (var i = 0; i < denominations.Length; i++)
        {
            var numberOfThisCoinNeeded = 0;
            while (reversedDenominations[i] <= changeNeeded)
            {
                numberOfThisCoinNeeded++;
                changeNeeded -= reversedDenominations[i];
            }
            returnList.Add(numberOfThisCoinNeeded);
        }
        returnList.Reverse();
        return returnList;
    }
}
