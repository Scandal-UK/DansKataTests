namespace LcdDigits
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class LcdDigitsTests
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
        " _ " + Environment.NewLine +
        "| |" + Environment.NewLine +
        "|_|");
    }

    [Fact(DisplayName = "Given 1, should return pattern for 1")]
    public void GivenOne_ShouldReturnPatternFor1()
    {
      LcdDigits.Output(1).Should().Be(
        "   " + Environment.NewLine +
        "  |" + Environment.NewLine +
        "  |");
    }

    [Fact(DisplayName = "Given 2, should return pattern for 2")]
    public void GivenTwo_ShouldReturnPatternFor2()
    {
      LcdDigits.Output(2).Should().Be(
        " _ " + Environment.NewLine +
        " _|" + Environment.NewLine +
        "|_ ");
    }

    [Fact(DisplayName = "Given 3, should return pattern for 3")]
    public void Given3_ShouldReturnPatternFor3()
    {
      LcdDigits.Output(3).Should().Be(
        " _ " + Environment.NewLine +
        " _|" + Environment.NewLine +
        " _|");
    }

    [Fact(DisplayName = "Given 4, should return pattern for 4")]
    public void Given4_ShouldReturnPatternFor4()
    {
      LcdDigits.Output(4).Should().Be(
        "   " + Environment.NewLine +
        "|_|" + Environment.NewLine +
        "  |");
    }

    [Fact(DisplayName = "Given 5, should return pattern for 5")]
    public void Given5_ShouldReturnPatternFor5()
    {
      LcdDigits.Output(5).Should().Be(
        " _ " + Environment.NewLine +
        "|_ " + Environment.NewLine +
        " _|");
    }

    [Fact(DisplayName = "Given 6, should return pattern for 6")]
    public void Given6_ShouldReturnPatternFor6()
    {
      LcdDigits.Output(6).Should().Be(
        " _ " + Environment.NewLine +
        "|_ " + Environment.NewLine +
        "|_|");
    }

    [Fact(DisplayName = "Given 7, should return pattern for 7")]
    public void Given7_ShouldReturnPatternFor7()
    {
      LcdDigits.Output(7).Should().Be(
        " _ " + Environment.NewLine +
        "  |" + Environment.NewLine +
        "  |");
    }

    [Fact(DisplayName = "Given 8, should return pattern for 8")]
    public void Given8_ShouldReturnPatternFor8()
    {
      LcdDigits.Output(8).Should().Be(
        " _ " + Environment.NewLine +
        "|_|" + Environment.NewLine +
        "|_|");
    }

    [Fact(DisplayName = "Given 9, should return pattern for 9")]
    public void Given9_ShouldReturnPatternFor9()
    {
      LcdDigits.Output(9).Should().Be(
        " _ " + Environment.NewLine +
        "|_|" + Environment.NewLine +
        "  |");
    }

    [Fact(DisplayName = "Given 10, should return pattern for 10")]
    public void Given10_ShouldReturnPatternFor10()
    {
      LcdDigits.Output(10).Should().Be(
        "    _ " + Environment.NewLine +
        "  || |" + Environment.NewLine +
        "  ||_|");
    }

    [Fact(DisplayName = "Given 910, should return pattern for 910")]
    public void Given910_ShouldReturnPatternFor910()
    {
      LcdDigits.Output(910).Should().Be(
        " _     _ " + Environment.NewLine +
        "|_|  || |" + Environment.NewLine +
        "  |  ||_|");
    }
  }
}
