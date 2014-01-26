using System;
using System.Collections.Generic;
using System.Text;
//13.Write a program that reverses the words in given sentence.
    //Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".

class ReverseWordsInSentence
{
    static void Main()
    {
        string inputSentence = "C# is not C++, not PHP and not Delphi!";
        string[] sentenceToWords = inputSentence.Split(
            new char[] { ' ', ',', '?', '!', '(', ')', '-', '/', '/' },
            StringSplitOptions.RemoveEmptyEntries);
        List<char> signsAndIntervals = new List<char>();
        for (int i = 0; i < inputSentence.Length; i++)
        {
            if (inputSentence[i] == ' ' || inputSentence[i] == '!' || inputSentence[i] == ',' || inputSentence[i] == '.' || inputSentence[i] == '?')
            {
                signsAndIntervals.Add(inputSentence[i]);
                if (inputSentence[i] == ',')  //removing empty space after ','
                {
                    i++;
                }
            }
        }
        StringBuilder newSentence = new StringBuilder();
        int signCounter = 0;
        for (int i = sentenceToWords.Length -1; i >= 0; i--)
        {
            newSentence.Append(sentenceToWords[i]);
            if (signsAndIntervals[signCounter] != ',')
            {
                newSentence.Append(signsAndIntervals[signCounter]);
                signCounter++;
            }
            else
            {
                newSentence.Append(signsAndIntervals[signCounter]);
                newSentence.Append(signsAndIntervals[signCounter + 1]);
                signCounter++;
            }
        }
        Console.WriteLine(newSentence.ToString());
    }
}
