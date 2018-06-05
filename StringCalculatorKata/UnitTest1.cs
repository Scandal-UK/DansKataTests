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

    [Fact(DisplayName = "Given two numbers, should return sum")]
    public void GivenTwoNumbers_ShouldReturnSum()
    {
      Add("1,2").Should().Be(3);
      Add("8,5").Should().Be(13);
    }

    [Fact(DisplayName = "Given any amount of numbers, should return sum")]
    public void GivenAnyAmountOfNumbers_ShouldReturnSum()
    {
      Add("1,2,3,4").Should().Be(10);
      Add("8,5,986,12,89").Should().Be(1100);
    }

    public int Add(string numbers)
    {
      var total = 0;

      if (!string.IsNullOrEmpty(numbers))
      {
        if (numbers.IndexOf(',') > 0)
          foreach (string number in numbers.Split(','))
            total += int.Parse(number);
        else total = int.Parse(numbers);
      }

      return total;
    }
  }
}