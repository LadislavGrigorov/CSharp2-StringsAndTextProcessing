using System;
//4.Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
//		Example: The target substring is "in". The text is as follows:

class StringCount
{
    private static void StringCounter(string inputString, string searchString)
    {
        int counter = 0;
        int index = 0;
        while (true)
        {
            index = inputString.IndexOf(searchString, index + 1, StringComparison.InvariantCultureIgnoreCase);
            if (index == -1)
            {
                break;
            }
            counter++;
        }
        Console.WriteLine(counter);
    }
    static void Main()
    {
        string inputString = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string searchString = "in";
        StringCounter(inputString, searchString);
    }
}
