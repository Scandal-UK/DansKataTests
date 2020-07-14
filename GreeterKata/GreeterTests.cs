namespace GreeterKata
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class GreeterTests
  {
    private readonly Greeter greeter;

    public GreeterTests() => this.greeter = new Greeter(this.TodaysDateAtHour(13));

    private DateTime TodaysDateAtHour(int hour) => new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, hour, 0, 0);

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
        this.greeter.CurrentTime = this.TodaysDateAtHour(i);
        this.greeter.Greet("Bob")
          .Should().Be("Good morning Bob.");
      }
    }
  }
}
