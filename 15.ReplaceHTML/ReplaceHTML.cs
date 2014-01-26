using System;
//15.Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL]. Sample HTML fragment:

class ReplaceHTML
{
    static void Main()
    {
        string htmlText = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        htmlText = htmlText.Replace("<a href=\"", "[URL=");
        htmlText = htmlText.Replace("</a>", "[/URL]");
        htmlText = htmlText.Replace("\">", "]");
        Console.WriteLine(htmlText);
    }
}
