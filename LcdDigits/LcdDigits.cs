namespace LcdDigits
{
  using System;

  public class LcdDigits
  {
    public static readonly string[] PatternFor0 = new string[3]
    {
      "._.",
      "|.|",
      "|_|",
    };

    public static readonly string[] PatternFor1 = new string[3]
    {
      "...",
      "..|",
      "..|",
    };

    public static readonly string[] PatternFor2 = new string[3]
    {
      "._.",
      "._|",
      "|_.",
    };

    public static string Output(int number)
    {
      if (number < 0)
        throw new ArgumentException($"{nameof(number)} cannot be less than zero");

      if (number == 1)
        return string.Join(Environment.NewLine, PatternFor1);
      else if (number == 2)
        return string.Join(Environment.NewLine, PatternFor2);
      else
        return string.Join(Environment.NewLine, PatternFor0);
    }
  }
}
