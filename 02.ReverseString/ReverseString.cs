using System;
using System.Text;
//2. Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class ReverseString
{
    private static StringBuilder ReversingString(string str)
    {
        StringBuilder reversed = new StringBuilder(str.Length);
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed.Append(str[i]);
        }
        return reversed;
    }
    static void Main()
    {
        string str = "sample";
        StringBuilder reversed = ReversingString(str);
        Console.WriteLine(reversed.ToString());
    }
}
