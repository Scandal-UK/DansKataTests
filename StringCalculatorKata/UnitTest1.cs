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

    public int Add(string numbers)
    {
      return 0;
    }
  }
}