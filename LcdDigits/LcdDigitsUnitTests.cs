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

    [Fact(DisplayName = "Given 0, should return pattern for 0")]
    public void GivenZero_ShouldReturnPatternFor0()
    {
      LcdDigits.Output(0).Should().Be(
        "._." + Environment.NewLine +
        "|.|" + Environment.NewLine +
        "|_|");
    }

    [Fact(DisplayName = "Given 1, should return pattern for 1")]
    public void GivenOne_ShouldReturnPatternFor1()
    {
      LcdDigits.Output(1).Should().Be(
        "..." + Environment.NewLine +
        "..|" + Environment.NewLine +
        "..|");
    }

    [Fact(DisplayName = "Given 2, should return pattern for 2")]
    public void GivenTwo_ShouldReturnPatternFor2()
    {
      LcdDigits.Output(2).Should().Be(
        "._." + Environment.NewLine +
        "._|" + Environment.NewLine +
        "|_.");
    }
  }
}
