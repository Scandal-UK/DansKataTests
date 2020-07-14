namespace GreeterKata
{
  using System;
  using FluentAssertions;
  using Xunit;

  public class GreeterTests
  {
    private readonly Greeter greeter;

    public GreeterTests() => this.greeter = new Greeter(this.TodaysDateAtTime(13));

    private DateTime TodaysDateAtTime(int hour) => new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, hour, 0, 0);

    [Fact]
    public void GivenNull_ShouldThrowNullReferenceException()
    {
      Action act = () => this.greeter.Greet(null);
      act.Should().Throw<NullReferenceException>();
    }

    [Fact]
    public void GivenName_ReturnsGreeting() =>
      this.greeter.Greet("Bob")
        .Should().Be("Hello Bob.");

    [Fact]
    public void GivenSpaces_ReturnsTrimmedGreeting() =>
      this.greeter.Greet("  Bob ")
        .Should().Be("Hello Bob.");

    [Fact]
    public void GivenLowerCase_ShouldCapitiliseFirstCharacter() =>
      this.greeter.Greet("bob")
        .Should().Be("Hello Bob.");

    [Fact]
    public void GivenNameAtMorning_ReturnsGoodMorningGreeting()
    {
      for (var i = 6; i < 12; i++)
      {
        this.greeter.CurrentTime = this.TodaysDateAtTime(i);
        this.greeter.Greet("Bob")
          .Should().Be("Good morning Bob.");
      }
    }

    [Fact]
    public void GivenNameInEvening_ReturnsGoodEveningGreeting()
    {
      for (var i = 18; i < 22; i++)
      {
        this.greeter.CurrentTime = this.TodaysDateAtTime(i);
        this.greeter.Greet("Bob")
          .Should().Be("Good evening Bob.");
      }
    }

    [Fact]
    public void GivenNameAtNight_ReturnsGoodNightGreeting()
    {
      var date = this.TodaysDateAtTime(22);
      while (date < this.TodaysDateAtTime(22).AddHours(8))
      {
        this.greeter.CurrentTime = date;
        this.greeter.Greet("Bob")
          .Should().Be("Good night Bob.");

        date = date.AddHours(1);
      }
    }

    [Fact]
    public void GivenNameAtOtherTimes_ShouldReturnUsualGreeting()
    {
      for (var i = 12; i < 18; i++)
      {
        this.greeter.CurrentTime = this.TodaysDateAtTime(i);
        this.greeter.Greet("Bob")
          .Should().Be("Hello Bob.");
      }
    }
  }
}
