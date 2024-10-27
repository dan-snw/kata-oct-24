using FluentAssertions;
using Kata;

namespace Tests;

public class ChangeCalculatorTests
{
    [Theory]
    [InlineData(0, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 0, 0, 0, 0, 0, 0, 0, 0 })]
    [InlineData(1, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 1, 0, 0, 0, 0, 0, 0, 0 })]
    [InlineData(2, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 0, 1, 0, 0, 0, 0, 0, 0 })]
    [InlineData(3, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 1, 1, 0, 0, 0, 0, 0, 0 })]
    [InlineData(4, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 0, 2, 0, 0, 0, 0, 0, 0 })]
    [InlineData(15, new[] { 1, 2, 5, 10, 20, 50 }, new [] { 0, 0, 1, 1, 0, 0 })]
    [InlineData(45, new[] { 1, 2, 5, 10, 20, 50 }, new [] { 0, 0, 1, 0, 2, 0 })]
    public void ChangeCalculator_ShouldReturnCorrectChange(int changeNeeded, int[] denominations, int[] expected) =>
        ChangeCalculator.GetChange(changeNeeded, denominations).Should().BeEquivalentTo(expected);
}
