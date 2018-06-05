namespace StringCalculatorKata
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class UnitTest1
  {
    [Fact(DisplayName = "Given empty string, should return zero")]
    public void GivenEmptyString_ShouldReturnZero()
    {
      StringCalculator.Add("").Should().Be(0);
    }

    [Fact(DisplayName = "Given single number, should return number")]
    public void GivenSingleNumber_ShouldReturnNumber()
    {
      StringCalculator.Add("1").Should().Be(1);
      StringCalculator.Add("7").Should().Be(7);
    }

    [Fact(DisplayName = "Given two numbers, should return sum")]
    public void GivenTwoNumbers_ShouldReturnSum()
    {
      StringCalculator.Add("1,2").Should().Be(3);
      StringCalculator.Add("8,5").Should().Be(13);
    }

    [Fact(DisplayName = "Given any amount of numbers, should return sum")]
    public void GivenAnyAmountOfNumbers_ShouldReturnSum()
    {
      StringCalculator.Add("1,2,3,4").Should().Be(10);
      StringCalculator.Add("8,5,986,12,89").Should().Be(1100);
    }

    [Fact(DisplayName = "Given new line & comma delimiters, should return sum")]
    public void GivenNewLineAndCommaDelimiters_ShouldReturnSum()
    {
      StringCalculator.Add("1\n2,3").Should().Be(6);
    }

    [Fact(DisplayName = "Given custom delimiter, should return sum")]
    public void GivenCustomDelimiter_ShouldReturnSum()
    {
      StringCalculator.Add("\\;\n1;2").Should().Be(3);
    }

    [Fact(DisplayName = "Given negative number, should throw exception")]
    public void GivenNegativeNumber_ShouldThrowException()
    {
      Action act = () => StringCalculator.Add("1,2,-3");
      act.Should().Throw<Exception>()
        .WithMessage("Negatives not allowed");
    }
  }
}