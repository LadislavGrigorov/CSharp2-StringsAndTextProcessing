using System;
using System.Globalization;
//17.Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

class DateAfter6Hours
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        CultureInfo bulgarian = new CultureInfo("bg-BG");
        string currentDate = "31.12.2013 19:00:30";
        DateTime date = DateTime.ParseExact(currentDate, "d.MM.yyyy HH:mm:ss",CultureInfo.CurrentCulture);
        date = date.AddHours(6);
        date = date.AddMinutes(30);
        Console.WriteLine("{0:dd.MM.yyyy HH.mm.ss}, {1}",date, bulgarian.DateTimeFormat.DayNames[(int)date.DayOfWeek]);
    }
}
