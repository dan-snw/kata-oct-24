using FluentAssertions;
using Kata;

namespace Tests;

public class ChangeCalculatorTests
{
    [Fact]
    public void ChangeCalculator_Should_ReturnTrue()
    {
        var denominations = new List<int> { 1, 2, 5, 10, 20, 50, 100, 200 };
        var changeNeeded = 0;
        ChangeCalculator.GetChange(changeNeeded, denominations).Should().BeEmpty();
    }
}
