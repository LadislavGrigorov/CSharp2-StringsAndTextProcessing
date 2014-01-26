using System;
//9. We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. Example:

	
        //Words: "PHP, CLR, Microsoft"
        //The expected result:

class ForbiddenWords
{
    static void Main()
    {
        string[] forbiddenWords = new string[]
        {
            "PHP", "CLR", "Microsoft"
        };
        string inputText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
        for (int i = 0; i < forbiddenWords.Length; i++)
        {
            inputText = inputText.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
        }
        Console.WriteLine(inputText);
    }
}
