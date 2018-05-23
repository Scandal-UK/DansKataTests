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
      RomanToDecimal(null)
        .Should().Be(0);
    }

    [Fact]
    public void GivenEmptyString_ShouldReturnZero()
    {
      RomanToDecimal(string.Empty)
        .Should().Be(0);
    }

    [Fact]
    public void GivenI_ShouldReturn1()
    {
      RomanToDecimal("I")
        .Should().Be(1);
    }

    [Fact]
    public void GivenV_ShouldReturn5()
    {
      RomanToDecimal("V")
        .Should().Be(5);
    }

    [Fact]
    public void GivenX_ShouldReturn10()
    {
      RomanToDecimal("X")
        .Should().Be(10);
    }

    [Fact]
    public void GivenL_ShouldReturn50()
    {
      RomanToDecimal("L")
        .Should().Be(50);
    }

    [Fact]
    public void GivenC_ShouldReturn100()
    {
      RomanToDecimal("C")
        .Should().Be(100);
    }

    [Fact]
    public void GivenD_ShouldReturn500()
    {
      RomanToDecimal("D")
        .Should().Be(500);
    }

    [Fact]
    public void GivenM_ShouldReturn1000()
    {
      RomanToDecimal("M")
        .Should().Be(1000);
    }

    public static int RomanToDecimal(string value)
    {
      switch (value)
      {
        case "I": return 1;
        case "V": return 5;
        case "X": return 10;
        case "L": return 50;
        case "C": return 100;
        case "D": return 500;
        case "M": return 1000;
        default: return 0;
      }
    }
  }
}
