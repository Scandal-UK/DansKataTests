namespace StringCalculatorKata
{
  using System;
  using System.Text.RegularExpressions;

  public class StringCalculator
  {
    public static int Add(string numbers)
    {
      var total = 0;

      if (!string.IsNullOrEmpty(numbers))
        foreach (string number in SplitNumbers(numbers))
          if (int.Parse(number) < 0) throw new Exception("Negatives not allowed");
          else total += int.Parse(number);

      return total;
    }

    private static string[] SplitNumbers(string numbers)
    {
      var delimiter = ",";
      if (numbers.IndexOf("\\") == 0)
      {
        delimiter = string.Format("\\{0}", numbers.Substring(1, (numbers.IndexOf('\n') - 1)));
        numbers = numbers.Substring(numbers.IndexOf("\n") + 1);
      }

      return Regex.Split(numbers, $"[\n{delimiter}]");
    }
  }
}
