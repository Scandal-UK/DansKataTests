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
  }
}
