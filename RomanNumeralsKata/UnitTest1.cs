using System;
using FluentAssertions;
using Xunit;

namespace RomanNumeralsKata
{
  public class UnitTest1
  {
    [Fact]
    public void Given_Null_Should_Return_Zero()
    {
      var output = RomanToDecimal(null);
      output.Should().Be(0);
    }

    public static int RomanToDecimal(string value)
    {
      return 0;
    }
  }
}
