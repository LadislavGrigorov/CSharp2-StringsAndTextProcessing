using System;
using System.Text;
//23.Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".

class SeriesToSingleChars
{
    static void Main()
    {
        string inputText = "aaaaabbbbbcdddeeeedssaa";
        StringBuilder singeCharString= new StringBuilder();
        char previousChar = inputText[0];
        singeCharString.Append(previousChar);
        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i]!=previousChar)
            {
                singeCharString.Append(inputText[i]);
                previousChar = inputText[i];
            }
        }
        Console.WriteLine(singeCharString.ToString());
    }
}
