using System;
//11.Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols.

class ConvertNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", number);

        string numberToHex = number.ToString("X");
        Console.WriteLine("{0,15}", numberToHex);

        string numberToPercentage = number.ToString("P");
        Console.WriteLine("{0,15}", numberToPercentage);

        string numberToScientificNotation = number.ToString("E");
        Console.WriteLine("{0,15}", numberToScientificNotation);
    }
}
