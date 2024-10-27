using FluentAssertions;
using Kata;

namespace Tests;

public class ChangeCalculatorTests
{
    [Theory]
    [InlineData(0, new[] { 1, 2, 5, 10, 20, 50, 100, 200 })]
    public void ChangeCalculator_ForZeroNeeded_ReturnsListOfZerosRightLength(int changeNeeded, int[] denominations)
    {
        var length = denominations.Length;

        var result = ChangeCalculator.GetChange(changeNeeded, denominations);
        result.Count.Should().Be(length);
    }

    [Fact]
    public void ChangeCalculator_For1Needed_Returns1ThenZeroes()
    {
        var denominations = new[] { 1, 2, 5, 10, 20, 50, 100, 200 };
        const int changeNeeded = 1;

        var length = denominations.Length;

        var result = ChangeCalculator.GetChange(changeNeeded, denominations);
        result.Count.Should().Be(length);
        result.Should().BeEquivalentTo(new List<int>() {1,0,0,0,0,0,0,0});
    }

    [Fact]
    public void ChangeCalculator_For2Needed_Returns1ThenZeroes()
    {
        var denominations = new[] { 1, 2, 5, 10, 20, 50, 100, 200 };
        const int changeNeeded = 2;

        var length = denominations.Length;

        var result = ChangeCalculator.GetChange(changeNeeded, denominations);
        result.Count.Should().Be(length);
        result.Should().BeEquivalentTo(new List<int>() {0,1,0,0,0,0,0,0});
    }
}
