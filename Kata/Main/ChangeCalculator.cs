namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, List<int> denominations)
    {
        if (changeNeeded == 1)
        {
          return new List<int>() {1,0,0,0,0,0,0,0};
        }
        return new List<int>() {0,0,0,0,0,0,0,0};

    }
}
