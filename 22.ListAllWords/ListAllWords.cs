using System;
//22.Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

class ListAllWords
{
    static void Main()
    {
        string inputText = "The little ABBA went to the big lamel, where she found a big exe. The exe was standing at the gate rotator! Who is she and where she came from?";
        inputText = inputText.ToLower();
        char[] separators = new char[] { ' ', ',', '!', '?', '.', '-', '(', ')' };
        string[] words = inputText.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < words.Length; i++)
        {
            int counter = 0;
            string currentWord = words[i];
            if (words[i]!="")
            {
                for (int k = i  ; k < words.Length; k++)
                {
                    if (words[k]==words[i])
                    {
                        counter++;
                    }
                }
            }
            if (counter>0)
            {
                Console.WriteLine("{0} - {1} times", currentWord, counter);
            }
        }
    }
}
