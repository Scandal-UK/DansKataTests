namespace GreeterKata
{
  using FluentAssertions;
  using Xunit;

  public class GreeterTests
  {
    [Fact]
    public void GivenName_ReturnsGreeting()
    {
      Greeter.Greet("Bob")
        .Should().Be("Hello Bob.");
    }

    [Fact]
    public void GivenSpaces_ReturnsTrimmedGreeting()
    {
      Greeter.Greet("  Bob ")
        .Should().Be("Hello Bob.");
    }

    [Fact]
    public void GivenLowerCase_ShouldCapitiliseFirstCharacter()
    {
      Greeter.Greet("bob")
        .Should().Be("Hello Bob.");
    }
  }
}
