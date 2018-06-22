namespace RomanNumeralsKata
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class DecimalToNumeralTests
  {
    [Fact(DisplayName = "Given negative value, should throw exception")]
    public void GivenNegativeValue_ShouldThrowException()
    {
      Action act = () => DecimalToNumeral.ConvertDecimal(-1);
      act.Should().Throw<Exception>()
        .WithMessage("Negatives not allowed");
    }

    [Fact(DisplayName = "Given zero, should return empty string")]
    public void GivenZero_ShouldReturnEmptyString()
    {
      DecimalToNumeral.ConvertDecimal(0).Should().Be(string.Empty);
    }

    [Fact(DisplayName = "Given 1, should return I")]
    public void Given1_ShouldReturnI()
    {
      DecimalToNumeral.ConvertDecimal(1).Should().Be("I");
    }
  }
}
