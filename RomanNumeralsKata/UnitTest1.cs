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

    [Fact]
    public void GivenRepeatedNumerals_ShouldReturnAddedTotal()
    {
      RomanToDecimal("III")
        .Should().Be(3);

      RomanToDecimal("XX")
        .Should().Be(20);
    }

    [Fact]
    public void GivenDescendingNumerals_ShouldReturnAddedTotal()
    {
      RomanToDecimal("MMVI")
        .Should().Be(2006);
    }

    [Fact]
    public void GivenAscendingNumerals_ShouldReturnSubtractedTotal()
    {
      RomanToDecimal("IV")
        .Should().Be(4);

      RomanToDecimal("CM")
        .Should().Be(900);
    }

    [Fact]
    public void GivenAscendingAndDescendingNumerals_ShouldReturnCorrectTotal()
    {
      RomanToDecimal("MCMXLIV")
        .Should().Be(1944);
    }

    public static int RomanToDecimal(string value)
    {
      var numericValue = 0;

      if (!string.IsNullOrEmpty(value)) 
      {
        for (int i = 0; i < value.Length; i++)
          numericValue += NumeralModifier(value, i);
      }

      return numericValue;
    }

    private static int NumeralModifier(string sourceNumeral, int currentIndex)
    {
      var currentVal = RomanCharacterValue(sourceNumeral[currentIndex]);

      if (currentIndex == sourceNumeral.Length - 1)
      {
        return currentVal;
      }
      else
      {
        var nextVal = RomanCharacterValue(sourceNumeral[currentIndex + 1]);
        if (currentVal < nextVal)
        {
          return -currentVal;
        }
        else
        {
          return currentVal;
        }
      }
    }

    private static int RomanCharacterValue(char value)
    {
      switch (value)
      {
        case 'I': return 1;
        case 'V': return 5;
        case 'X': return 10;
        case 'L': return 50;
        case 'C': return 100;
        case 'D': return 500;
        case 'M': return 1000;
        default: return 0;
      }
    }
  }
}
