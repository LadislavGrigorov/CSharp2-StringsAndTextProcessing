using System;
using System.Text.RegularExpressions;
//20.Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

class ExtractPalindromes
{
    static void Main()
    {
        string inputText = "The little ABBA went to the big lamel, where she found a big exe. The exe was standing at the gate rotator!";
        string[] wordsInArray = inputText.Split(new char[] { ' ', ',', '!', '?', '.', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < wordsInArray.Length; i++)
        {
            bool isPalindrome = true;
            if (wordsInArray[i].Length > 1)
            {
                for (int k = 0; k <= wordsInArray[i].Length / 2; k++)
                {
                    if (wordsInArray[i][k] != wordsInArray[i][wordsInArray[i].Length - 1 - k])
                    {
                        isPalindrome = false;
                    }
                }
                if (isPalindrome)
                {
                    Console.WriteLine(wordsInArray[i]);
                }
            }
        }
    }
}
