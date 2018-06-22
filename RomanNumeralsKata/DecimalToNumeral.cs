namespace RomanNumeralsKata
{
  using System;

  public class DecimalToNumeral
  {
    public static string ConvertDecimal(int value)
    {
      if (value < 0)
        throw new Exception("Negatives not allowed");

      var numeral = string.Empty;

      if (value == 1) numeral = "I";

      return numeral;
    }
  }
}
