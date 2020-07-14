namespace GreeterKata
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class GreeterTests
  {
    private readonly Greeter greeter;

    public GreeterTests() => this.greeter = new Greeter(this.TodaysDateAtTime(13, 0));

    private DateTime TodaysDateAtTime(int hour, int min) => new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, hour, min, 0);

    [Fact]
    public void GivenName_ReturnsGreeting()
    {
      this.greeter.Greet("Bob")
        .Should().Be("Hello Bob.");
    }

    [Fact]
    public void GivenSpaces_ReturnsTrimmedGreeting()
    {
      this.greeter.Greet("  Bob ")
        .Should().Be("Hello Bob.");
    }

    [Fact]
    public void GivenLowerCase_ShouldCapitiliseFirstCharacter()
    {
      this.greeter.Greet("bob")
        .Should().Be("Hello Bob.");
    }

    [Fact]
    public void GivenNameAtMorning_ReturnsGoodMorningGreeting()
    {
      for (var i = 6; i < 12; i++)
      {
        this.greeter.CurrentTime = this.TodaysDateAtTime(i, 0);
        this.greeter.Greet("Bob")
          .Should().Be("Good morning Bob.");
      }
    }

    [Fact]
    public void GivenNameInEvening_ReturnGoodEveningGreeting()
    {
      for (var i = 18; i < 22; i++)
      {
        this.greeter.CurrentTime = this.TodaysDateAtTime(i, 0);
        this.greeter.Greet("Bob")
          .Should().Be("Good evening Bob.");
      }
    }
  }
}
