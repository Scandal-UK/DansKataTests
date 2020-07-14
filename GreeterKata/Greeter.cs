namespace GreeterKata
{
  using System;
  using System.Globalization;

  public class Greeter
  {
    public string Greet(string name)
    {
      var greeting = "Hello";
      return $"{greeting} {this.CleanName(name)}.";
    }

    private string CleanName(string name)
    {
      TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
      return ti.ToTitleCase(name.Trim());
    }
  }
}
