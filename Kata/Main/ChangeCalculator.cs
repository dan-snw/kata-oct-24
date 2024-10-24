namespace Kata;

public static class ChangeCalculator
{
    public static List<int> GetChange(int changeNeeded, List<int> denominations) => denominations.Select(t => t == changeNeeded ? 1 : 0).ToList();
}
