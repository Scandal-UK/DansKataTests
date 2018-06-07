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

  }
}
