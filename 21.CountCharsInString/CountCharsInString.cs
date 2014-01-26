using System;
//21.Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

class CountCharsInString
{
    static void Main()
    {
        string inputText = "The little ABBA went to the big lamel, where she found a big exe. The exe was standing at the gate rotator!";
        inputText = inputText.ToLower();
        for (int i = 0; i < inputText.Length; i++)
        {
            int counter = 0;
            if (char.IsLetter(inputText[i]))
            {
                for (int k = i; k < inputText.Length; k++)
                {
                    if (inputText[i]==inputText[k])
                    {
                        counter++;
                    }
                }
            }
            if (counter>0)
            {
                Console.WriteLine("{0} - {1} times", inputText[i], counter);
            }
            inputText = inputText.Replace(inputText[i], '*');
        }
    }
}
