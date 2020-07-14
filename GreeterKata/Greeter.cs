namespace GreeterKata
{
  using System.Globalization;

  public static class Greeter
  {
    public static string Greet(string name)
    {
      return $"Hello {CleanName(name)}.";
    }

    private static string CleanName(string name)
    {
      TextInfo ti = new CultureInfo("en-GB", false).TextInfo;
      return ti.ToTitleCase(name.Trim());
    }
  }
}
