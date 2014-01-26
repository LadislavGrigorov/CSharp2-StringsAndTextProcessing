using System;
using System.Text.RegularExpressions;
//18.Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.

class EmailValidation
{
    static void Main()
    {
        string inputText = "Please contact us by phone (+001 222 222 222) or by email at example@gmail.com or at test.user@yahoo.co.uk. This is not email: test@test. This also: @gmail.com. Neither this: a@a.b.";
        string[] separateWords = inputText.Split(' ');
        for (int i = 0; i < separateWords.Length; i++)
        {
            if (Regex.IsMatch(separateWords[i], @"[\w.]{2,64}@[\w]{2,249}[.]{1}[\w.]{2,5}"))
            {
                Console.WriteLine(separateWords[i].TrimEnd('.', '!', '?', ','));
            }
        }
    }
}
