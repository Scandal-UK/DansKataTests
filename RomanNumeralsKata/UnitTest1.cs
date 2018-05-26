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
      RomanNumeral.NumeralToDecimal(null)
        .Should().Be(0);
    }

    [Fact]
    public void GivenEmptyString_ShouldReturnZero()
    {
      RomanNumeral.NumeralToDecimal(string.Empty)
        .Should().Be(0);
    }

    [Fact]
    public void GivenI_ShouldReturn1()
    {
      RomanNumeral.NumeralToDecimal("I")
        .Should().Be(1);
    }

    [Fact]
    public void GivenV_ShouldReturn5()
    {
      RomanNumeral.NumeralToDecimal("V")
        .Should().Be(5);
    }

    [Fact]
    public void GivenX_ShouldReturn10()
    {
      RomanNumeral.NumeralToDecimal("X")
        .Should().Be(10);
    }

    [Fact]
    public void GivenL_ShouldReturn50()
    {
      RomanNumeral.NumeralToDecimal("L")
        .Should().Be(50);
    }

    [Fact]
    public void GivenC_ShouldReturn100()
    {
      RomanNumeral.NumeralToDecimal("C")
        .Should().Be(100);
    }

    [Fact]
    public void GivenD_ShouldReturn500()
    {
      RomanNumeral.NumeralToDecimal("D")
        .Should().Be(500);
    }

    [Fact]
    public void GivenM_ShouldReturn1000()
    {
      RomanNumeral.NumeralToDecimal("M")
        .Should().Be(1000);
    }

    [Fact]
    public void GivenRepeatedNumerals_ShouldReturnAddedTotal()
    {
      RomanNumeral.NumeralToDecimal("III")
        .Should().Be(3);

      RomanNumeral.NumeralToDecimal("XX")
        .Should().Be(20);
    }

    [Fact]
    public void GivenDescendingNumerals_ShouldReturnAddedTotal()
    {
      RomanNumeral.NumeralToDecimal("MMVI")
        .Should().Be(2006);
    }

    [Fact]
    public void GivenAscendingNumerals_ShouldReturnSubtractedTotal()
    {
      RomanNumeral.NumeralToDecimal("IV")
        .Should().Be(4);

      RomanNumeral.NumeralToDecimal("CM")
        .Should().Be(900);
    }

    [Fact]
    public void GivenAscendingAndDescendingNumerals_ShouldReturnCorrectTotal()
    {
      RomanNumeral.NumeralToDecimal("MCMXLIV")
        .Should().Be(1944);
    }
  }
}
