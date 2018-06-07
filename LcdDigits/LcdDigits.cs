namespace LcdDigits
{
  using System;
  using System.Collections.Generic;

  public class LcdDigits
  {
    private static readonly List<string[]> Pattern = new List<string[]>()
    {
      new string[3] {
        "._.",
        "|.|",
        "|_|",
      },
      new string[3] {
        "...",
        "..|",
        "..|",
      },
      new string[3] {
        "._.",
        "._|",
        "|_.",
      },
    };

    public static string Output(int number)
    {
      if (number < 0)
        throw new ArgumentException($"{nameof(number)} cannot be less than zero");

      return string.Join(Environment.NewLine, Pattern[number]);
    }
  }
}
