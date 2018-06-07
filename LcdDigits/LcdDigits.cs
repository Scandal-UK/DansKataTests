namespace LcdDigits
{
  using System;

  public class LcdDigits
  {
    public static readonly string PatternFor0 =
      "._." + Environment.NewLine +
      "|.|" + Environment.NewLine +
      "|_|";

    public static readonly string PatternFor1 =
      "..." + Environment.NewLine +
      "..|" + Environment.NewLine +
      "..|";

    public static string Output(int number)
    {
      if (number < 0)
      {
        throw new ArgumentException($"{nameof(number)} cannot be less than zero");
      }

      return string.Join(Environment.NewLine, (number == 1) ? PatternFor1 : PatternFor0);
    }
  }
}
