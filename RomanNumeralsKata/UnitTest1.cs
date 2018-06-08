namespace RomanNumeralsKata
{
  using FluentAssertions;
  using Xunit;

  public class RomanNumeralTests
  {
    [Fact(DisplayName = "Given null, should return zero")]
    public void GivenNull_ShouldReturnZero()
    {
      RomanNumeral.NumeralToDecimal(null)
        .Should().Be(0);
    }

    [Fact(DisplayName = "Given empty string, should return zero")]
    public void GivenEmptyString_ShouldReturnZero()
    {
      RomanNumeral.NumeralToDecimal(string.Empty)
        .Should().Be(0);
    }

    [Fact(DisplayName = "For numeral I, should return 1")]
    public void GivenI_ShouldReturn1()
    {
      RomanNumeral.NumeralToDecimal("I")
        .Should().Be(1);
    }

    [Fact(DisplayName = "For numeral V, should return 5")]
    public void GivenV_ShouldReturn5()
    {
      RomanNumeral.NumeralToDecimal("V")
        .Should().Be(5);
    }

    [Fact(DisplayName = "For numeral X, should return 10")]
    public void GivenX_ShouldReturn10()
    {
      RomanNumeral.NumeralToDecimal("X")
        .Should().Be(10);
    }

    [Fact(DisplayName = "For numeral L, should return 50")]
    public void GivenL_ShouldReturn50()
    {
      RomanNumeral.NumeralToDecimal("L")
        .Should().Be(50);
    }

    [Fact(DisplayName = "For numeral C, should return 100")]
    public void GivenC_ShouldReturn100()
    {
      RomanNumeral.NumeralToDecimal("C")
        .Should().Be(100);
    }

    [Fact(DisplayName = "For numeral D, should return 500")]
    public void GivenD_ShouldReturn500()
    {
      RomanNumeral.NumeralToDecimal("D")
        .Should().Be(500);
    }

    [Fact(DisplayName = "For numeral M, should return 1,000")]
    public void GivenM_ShouldReturn1000()
    {
      RomanNumeral.NumeralToDecimal("M")
        .Should().Be(1000);
    }

    [Fact(DisplayName = "Given repeated numerals, should return added total")]
    public void GivenRepeatedNumerals_ShouldReturnAddedTotal()
    {
      RomanNumeral.NumeralToDecimal("III")
        .Should().Be(3);

      RomanNumeral.NumeralToDecimal("XX")
        .Should().Be(20);
    }

    [Fact(DisplayName = "Given descending numerals, should return added total")]
    public void GivenDescendingNumerals_ShouldReturnAddedTotal()
    {
      RomanNumeral.NumeralToDecimal("MMVI")
        .Should().Be(2006);
    }

    [Fact(DisplayName = "Given ascending numerals, should return subtracted total")]
    public void GivenAscendingNumerals_ShouldReturnSubtractedTotal()
    {
      RomanNumeral.NumeralToDecimal("IV")
        .Should().Be(4);

      RomanNumeral.NumeralToDecimal("CM")
        .Should().Be(900);
    }

    [Fact(DisplayName = "Given ascending & descending numerals, should return correct totals")]
    public void GivenAscendingAndDescendingNumerals_ShouldReturnCorrectTotal()
    {
      RomanNumeral.NumeralToDecimal("MCMXLIV")
        .Should().Be(1944);
    }
  }
}
