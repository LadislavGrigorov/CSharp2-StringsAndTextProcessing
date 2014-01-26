using System;
/*8.Write a program that extracts from a given text all sentences containing given word.
		Example: The word is "in". The text is:


		The expected result is:


		Consider that the sentences are separated by "." and the words – by non-letter symbols.*/

class ExtractSentences
{
    private static void PrintSentenceFromString(string inputString, int startIndex, int endIndex)
    {
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(inputString[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        string inputString = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        int index = -1;
        while (inputString.IndexOf(word, index + 1) != -1)
        {
            //finds the word index in the string
            index = inputString.IndexOf(word, index + 1, StringComparison.InvariantCultureIgnoreCase);
            //check if the word is not a substring from another word
            if (!(Char.IsLetter(inputString[index - 1])) && !(Char.IsLetter(inputString[index + word.Length])))
            {
                int startIndex = index;
                //finds the end of the previous sentence or the begining of the string if it's the first sentence
                while (inputString[startIndex] != '.' && startIndex != 0)
                {
                    startIndex--;
                }
                //finds the first capital letter after the end of the previous sentence
                //if there are names like John, Pesho.... in the sentence.
                while (!Char.IsUpper(inputString[startIndex]))
                {
                    startIndex++;
                }
                int endIndex = inputString.IndexOf('.', index + 1);
                PrintSentenceFromString(inputString, startIndex, endIndex);

            }
        }
    }
}
