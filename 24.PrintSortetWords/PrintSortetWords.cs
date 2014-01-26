using System;
//24.Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

class PrintSortetWords
{
    static void Main()
    {
        string inputString = "dog cat mouse elephan sun mother father son house chair window Pesho zoo key day whatever";
        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(words);
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }
    }
}
