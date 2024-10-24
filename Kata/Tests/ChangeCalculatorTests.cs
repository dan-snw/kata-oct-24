using FluentAssertions;

namespace Tests;

public class ChangeCalculatorTests
{
    [Fact]
    public void ChangeCalculator_Should_ReturnTrue()
    {
        true.Should().Be(true);
    }
}
