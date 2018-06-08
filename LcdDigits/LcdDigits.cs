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

      var output = new StringBuilder();

      for (int lineIndex = 0; lineIndex < 3; lineIndex++)
        AppendWholeNumberLine(numberToDisplay.ToString(), output, lineIndex);

      return output.ToString();
    }

    private static void AppendWholeNumberLine(string wholeNumber, StringBuilder output, int lineIndex)
    {
      for (int digitIndex = 0; digitIndex < wholeNumber.Length; digitIndex++)
        output.Append(AppendDigit(wholeNumber[digitIndex], digitIndex, lineIndex));

      if (lineIndex < 2) output.Append(Environment.NewLine);
    }

    private static string AppendDigit(char value, int digitIndex, int lineIndex)
    {
      var patternIndex = Convert.ToInt32(Char.GetNumericValue(value));
      return Pattern[patternIndex][lineIndex];
    }
  }
}
