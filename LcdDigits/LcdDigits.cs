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

      for (int line = 0; line < 3; line++)
      {
        for (int number = 0; number < wholeNumber.Length; number++)
        {
          var currentValue = Convert.ToInt32(Char.GetNumericValue(wholeNumber[number]));
          output.Append(Pattern[currentValue][line]);
        }

        if (line < 2) output.Append(Environment.NewLine);
      }

      return output.ToString();
    }
  }
}
