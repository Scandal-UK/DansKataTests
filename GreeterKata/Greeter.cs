namespace GreeterKata
{
  using System;
  using System.Globalization;

  public class Greeter
  {
    public DateTime CurrentTime { get; set; }

    public Greeter(DateTime currentTime) => this.CurrentTime = currentTime;

    public string Greet(string name)
    {
      var greeting = "Hello";
      if (this.CurrentTime.Hour >= 6 && this.CurrentTime.Hour < 12)
        greeting = "Good morning";

      return $"{greeting} {this.CleanName(name)}.";
    }

    private string CleanName(string name)
    {
      TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
      return ti.ToTitleCase(name.Trim());
    }
  }
}
