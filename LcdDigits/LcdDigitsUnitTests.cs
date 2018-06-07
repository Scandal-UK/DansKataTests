namespace LcdDigits
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class LcdDigitsUnitTests
  {
    [Fact(DisplayName = "Given negative number, should throw argument exception")]
    public void GivenNegativeNumber_ShouldThrowArgumentException()
    {
      Action act = () => LcdDigits.Output(-1);
      act.Should().Throw<ArgumentException>();
    }

    [Fact(DisplayName = "Given zero, should return zero pattern")]
    public void GivenZero_ShouldReturnZeroPattern()
    {
      LcdDigits.Output(0).Should().Be(LcdDigits.PATTERN_FOR_0);
    }

    [Fact(DisplayName = "Given 1, should return pattern for 1")]
    public void GivenOne_ShouldReturnPatternFor1()
    {
      LcdDigits.Output(1).Should().Be(LcdDigits.PATTERN_FOR_1);
    }
  }
}
