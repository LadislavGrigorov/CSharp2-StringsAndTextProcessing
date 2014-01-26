using System;
using System.Globalization;
using System.Text.RegularExpressions;
//19.Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

class Program
{
    static void Main()
    {
        string inputText = "I was born at 14.06.1980. My sister was born at 3.7.1984. In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are allowed to do this (section 7.4.2.9).";
        CultureInfo ci = new CultureInfo("en-CA");
        string[] separateWords = inputText.Split(' ');
        DateTime date = new DateTime();
        string dateFormat = "d.M.yyyy";
        for (int i = 0; i < separateWords.Length; i++)
        {
            if (Regex.IsMatch(separateWords[i], @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
            {
                separateWords[i] = separateWords[i].TrimEnd('.', '!', '?', ',', ')');
                separateWords[i] = separateWords[i].TrimStart('(');
                if (DateTime.TryParseExact(separateWords[i], dateFormat, ci, DateTimeStyles.None, out date))
                {
                    Console.WriteLine(date.ToString("d", ci));
                }
            }
        }
    }
}
