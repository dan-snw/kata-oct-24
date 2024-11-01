using FluentAssertions;
using Kata;

namespace Tests;

public class ChangeCalculatorTests
{
    private static readonly int[] Denominations = [ 1, 2, 5, 10, 20, 50, 100, 200 ];
   
    [Theory]
    [InlineData(0, new int[] { })]
    [InlineData(1, new int[] { })]
    public void ChangeCalculator_EmptyArray_ShouldReturnEmptyArray(int changeNeeded, int[] expected) =>
        ChangeCalculator.GetChange(changeNeeded, []).Should().BeEquivalentTo(expected);
    
    [Theory]
    [InlineData(0, new [] { 0, 0, 0, 0, 0, 0, 0, 0 })]
    [InlineData(1, new [] { 1, 0, 0, 0, 0, 0, 0, 0 })]
    [InlineData(2, new [] { 0, 1, 0, 0, 0, 0, 0, 0 })]
    [InlineData(3, new [] { 1, 1, 0, 0, 0, 0, 0, 0 })]
    [InlineData(4, new [] { 0, 2, 0, 0, 0, 0, 0, 0 })]
    public void ChangeCalculator_ShouldReturnCorrectChange(int changeNeeded, int[] expected) =>
        ChangeCalculator.GetChange(changeNeeded, Denominations).Should().BeEquivalentTo(expected);
   
    [Theory]
    [InlineData(15, new[] { 1, 2, 5, 10, 20, 50 }, new [] { 0, 0, 1, 1, 0, 0 })]
    [InlineData(45, new[] { 1, 2, 5, 10, 20, 50 }, new [] { 0, 0, 1, 0, 2, 0 })]
    [InlineData(121, new[] { 1, 2, 5, 10, 20, 50, 100, 200 }, new [] { 1, 0, 0, 0, 1, 0, 1, 0 })]
    public void ChangeCalculator_SpecTests(int changeNeeded, int[] denominations, int[] expected) =>
        ChangeCalculator.GetChange(changeNeeded, denominations).Should().BeEquivalentTo(expected);
}
