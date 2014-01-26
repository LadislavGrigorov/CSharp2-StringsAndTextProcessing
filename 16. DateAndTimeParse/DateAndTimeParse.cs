using System;
using System.Globalization;
//16.Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. Example:

class DateAndTimeParse
{
    static void Main()
    {
        string firstDateString = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(firstDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);
        string secondDateString = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(secondDateString, "d.MM.yyyy", CultureInfo.InvariantCulture);
        Console.WriteLine("Distance: {0} days", (secondDate - firstDate).TotalDays);
    }
}
