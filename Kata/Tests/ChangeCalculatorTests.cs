using FluentAssertions;
using Kata;

namespace Tests;

public class ChangeCalculatorTests
{
    [Fact]
    public void ChangeCalculator_ForZeroNeeded_ReturnsListOfZerosRightLength()
    {
        var denominations = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
        const int changeNeeded = 0;

        var length = denominations.Count;

        var result = ChangeCalculator.GetChange(changeNeeded, denominations);
        result.Count.Should().Be(length);
    }
}