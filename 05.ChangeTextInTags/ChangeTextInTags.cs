using System;
using System.Text;
//5.You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. Example:
class ChangeTextInTags
{
    static void Main()
    {
        string inputText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        StringBuilder inputTextFormatted = new StringBuilder();
        for (int i = 0; i < inputText.Length; i++)
        {
            if (inputText[i]!='<')
            {
                inputTextFormatted.Append(inputText[i]);
            }
            else
            {
                i += 8; //skips the tag length
                while (inputText[i] != '<')
                {
                    inputTextFormatted.Append(Char.ToUpper(inputText[i]));
                    i++;
                }
                i += 8; //skips the closing tag length
            }
        }
        Console.WriteLine(inputTextFormatted.ToString());
    }
}
