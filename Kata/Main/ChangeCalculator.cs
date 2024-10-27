namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, int[] denominations)
    {
        var returnList = new List<int>();
        for(var i = denominations.Length - 1; i >= 0; i--)
        {
            if (denominations[i] <= changeNeeded)
            {
                returnList.Add(1);
                changeNeeded -= denominations[i];
            }
            else
            {
                returnList.Add(0);
            }
        }
        returnList.Reverse();
        return returnList;
    }
}
