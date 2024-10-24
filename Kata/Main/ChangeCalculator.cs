namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, List<int> denominations)
    {
        var returnList = new List<int>();
        if (changeNeeded == 1)
        {
          for(int i = 0; i < denominations.Count; i++)
          {
            if (denominations[i] == 1)
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
        return new List<int>() {0,0,0,0,0,0,0,0};

    }
}
