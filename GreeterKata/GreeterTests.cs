namespace GreeterKata
{
  using FluentAssertions;
  using Xunit;

  public class GreeterTests
  {
    private readonly Greeter greeter;

    public GreeterTests() => this.greeter = new Greeter();

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
  }
}
