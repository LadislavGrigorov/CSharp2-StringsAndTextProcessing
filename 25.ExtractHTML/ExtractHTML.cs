using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
//25.Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags. Example:

class ExtractHTML
{
    static void Main()
    {
        StreamReader reader = new StreamReader("html.txt");
        string inputText = reader.ReadToEnd();
        int index = inputText.IndexOf('>');
        while (index >= 0)
        {
            StringBuilder line = new StringBuilder();
            index++;
            while (index<inputText.Length && inputText[index] != '<')
            {
                line.Append(inputText[index]);
                index++;
            }
            Console.Write(line.ToString());
            index = inputText.IndexOf('>', index);
        }
    }
}
