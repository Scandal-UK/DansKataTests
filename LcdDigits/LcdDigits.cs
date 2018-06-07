namespace LcdDigits
{
  using System;
  using System.Collections.Generic;
  using System.Text;

  public class LcdDigits
  {
    public static readonly List<string[]> Pattern = new List<string[]>()
    {
      new string[3] {
        " _ ",
        "| |",
        "|_|",
      },
      new string[3] {
        "   ",
        "  |",
        "  |",
      },
      new string[3] {
        " _ ",
        " _|",
        "|_ ",
      },
      new string[3] {
        " _ ",
        " _|",
        " _|",
      },
      new string[3] {
        "   ",
        "|_|",
        "  |",
      },
      new string[3] {
        " _ ",
        "|_ ",
        " _|",
      },
      new string[3] {
        " _ ",
        "|_ ",
        "|_|",
      },
      new string[3] {
        " _ ",
        "  |",
        "  |",
      },
      new string[3] {
        " _ ",
        "|_|",
        "|_|",
      },
      new string[3] {
        " _ ",
        "|_|",
        "  |",
      },
    };

    public static string Output(int numberToDisplay)
    {
      if (numberToDisplay < 0)
        throw new ArgumentException($"{nameof(numberToDisplay)} cannot be less than zero");

      var wholeNumber = numberToDisplay.ToString();
      var output = new StringBuilder();

      for (int lineIndex = 0; lineIndex < 3; lineIndex++)
      {
        for (int digitIndex = 0; digitIndex < wholeNumber.Length; digitIndex++)
          AddDigitLine(output, lineIndex, Convert.ToInt32(Char.GetNumericValue(wholeNumber[digitIndex])));

        if (lineIndex < 2) output.Append(Environment.NewLine);
      }

      return output.ToString();
    }

    private static void AddDigitLine(StringBuilder output, int lineIndex, int currentValue)
    {
      output.Append(Pattern[currentValue][lineIndex]);
    }
  }
}
