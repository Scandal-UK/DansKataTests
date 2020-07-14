namespace GreeterKata
{
  using System;
  using System.Globalization;

  public class Greeter
  {
    public DateTime CurrentTime { get; set; }

    public Greeter(DateTime currentTime) => this.CurrentTime = currentTime;

    public static DateTime TodaysDateAtTime(int hour, int min) => new DateTime(DateTime.UtcNow.Year, DateTime.UtcNow.Month, DateTime.UtcNow.Day, hour, min, 0);

    public string Greet(string name) => $"{this.TimeBasedGreeting()} {this.CleanName(name)}.";

    private string TimeBasedGreeting()
    {
      var greeting = "Hello";
      if (this.CurrentTime.Hour >= 6 && this.CurrentTime.Hour < 12)
        greeting = "Good morning";
      else if (this.CurrentTime.Hour >= 18 && this.CurrentTime.Hour < 22)
        greeting = "Good evening";

      return greeting;
    }

    private string CleanName(string name)
    {
      TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
      return ti.ToTitleCase(name.Trim());
    }
  }
}
