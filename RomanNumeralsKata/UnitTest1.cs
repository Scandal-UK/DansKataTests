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

    [Fact]
    public void GivenV_ShouldReturn5()
    {
      var output = RomanToDecimal("V");
      output.Should().Be(5);
    }

    public static int RomanToDecimal(string value)
    {
      switch (value)
      {
        case "I": return 1;
        case "V": return 5;
        default: return 0;
      }
    }
  }
}
