namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, List<int> denominations)
    {
        var returnList = new List<int>();
        for(var i = denominations.Count - 1; i >= 0; i--)
        {
            if (denominations[i] == changeNeeded)
            {
                returnList.Add(1);
            }
            else
            {
                returnList.Add(0);
            }
        }
        return returnList;
    }
}
