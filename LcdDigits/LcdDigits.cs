namespace LcdDigits
{
  using System;

  public class LcdDigits
  {
    public const string ZERO_PATTERN = "._.\n|.|\n|_|";

    public static string Output(int number)
    {
      if (number < 0)
      {
        throw new ArgumentException($"{nameof(number)} cannot be less than zero");
      }

      return ZERO_PATTERN;
    }
  }
}
