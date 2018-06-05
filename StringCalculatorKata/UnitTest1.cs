using FluentAssertions;
using Xunit;

namespace StringCalculatorKata
{
  public class UnitTest1
  {
    [Fact(DisplayName = "Given empty string, should return zero")]
    public void GivenEmptyString_ShouldReturnZero()
    {
      Add("").Should().Be(0);
    }

    [Fact(DisplayName = "Given single number, should return number")]
    public void GivenSingleNumber_ShouldReturnNumber()
    {
      Add("1").Should().Be(1);
      Add("7").Should().Be(7);
    }

    public int Add(string numbers)
    {
      return 0;
    }
  }
}