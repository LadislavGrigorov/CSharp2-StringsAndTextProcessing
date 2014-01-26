using System;
//10.Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input:

//        Expected output:

class StringToUnicodeChars
{
    static void Main()
    {
        string stringInput = Console.ReadLine();
        for (int i = 0; i < stringInput.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)stringInput[i]);
        }
    }
}
