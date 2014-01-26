using System;
//6.Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.

class StringTo20Chars
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        if (inputString.Length>=21)
        {
            Console.WriteLine("The string must be not more than 20 chars!");
        }
        else
        {
            inputString = inputString.PadRight(20, '*');
            Console.WriteLine(inputString);
        }
    }
}
