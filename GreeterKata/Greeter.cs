namespace GreeterKata
{
  using System;
  using System.Globalization;

  public class Greeter
  {
    public DateTime CurrentTime { get; set; }

    public Greeter(DateTime currentTime) => this.CurrentTime = currentTime;

    public string Greet(string name) => $"{this.TimeBasedGreeting()} {CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.Trim())}.";

    private string TimeBasedGreeting()
    {
      var greeting = "Hello";
      if (this.CurrentTime.Hour >= 6 && this.CurrentTime.Hour < 12)
        greeting = "Good morning";
      else if (this.CurrentTime.Hour >= 18 && this.CurrentTime.Hour < 22)
        greeting = "Good evening";
      else if (this.CurrentTime.Hour >= 22 || this.CurrentTime.Hour <= 6)
        greeting = "Good night";

      return greeting;
    }
  }
}
