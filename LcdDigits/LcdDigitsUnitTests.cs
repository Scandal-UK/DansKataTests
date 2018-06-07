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
      Action act = () => LcdOutput(-1);
      act.Should().Throw<ArgumentException>();
    }

    public string LcdOutput(int number)
    {
      if (number < 0)
      {
        throw new ArgumentException($"{nameof(number)} cannot be less than zero");
      }

      return null;
    }
  }
}
