using System;
using FluentAssertions;
using Xunit;

namespace RomanNumeralsKata
{
  public class UnitTest1
  {
    [Fact]
    public void GivenNull_ShouldReturnZero()
    {
      var output = RomanToDecimal(null);
      output.Should().Be(0);
    }

    [Fact]
    public void GivenEmptyString_ShouldReturnZero()
    {
      var output = RomanToDecimal(string.Empty);
      output.Should().Be(0);
    }

    [Fact]
    public void GivenI_ShouldReturn1()
    {
      var output = RomanToDecimal("I");
      output.Should().Be(1);
    }

    public static int RomanToDecimal(string value)
    {
      return value == "I" ? 1 : 0;
    }
  }
}
