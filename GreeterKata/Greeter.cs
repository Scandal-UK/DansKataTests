namespace GreeterKata
{
  using System.Globalization;

  public static class Greeter
  {
    public static string Greet(string name)
    {
      TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
      return $"Hello {ti.ToTitleCase(name.Trim())}.";
    }
  }
}
