using System;
//14.A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:

class Dictionary
{
    static void Main()
    {
        string dictionary = @".NET – platform for applications from Microsoft
CLR – managed execution environment for .NET
namespace – hierarchical organization of classes";
        string word = Console.ReadLine();
        word = string.Concat(word, " – ");
        int index = dictionary.IndexOf(word);
        if (index == -1)
        {
            Console.WriteLine("The word you entered do not exist in the dictionary");
        }
        else
        {
            while ((index <= dictionary.Length - 1) && dictionary[index] != '\n')
            {
                Console.Write(dictionary[index]);
                index++;
            }
            Console.WriteLine();
        }
    }
}
