namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, int[] denominations)
    {
        var returnList = new List<int>();
        for(var i = denominations.Length - 1; i >= 0; i--)
        {
            var numberOfThisCoinNeeded = 0;
            while (denominations[i] <= changeNeeded)
            {
                numberOfThisCoinNeeded++;
                changeNeeded -= denominations[i];
            }
            returnList.Add(numberOfThisCoinNeeded);
        }
        returnList.Reverse();
        return returnList;
    }
}
