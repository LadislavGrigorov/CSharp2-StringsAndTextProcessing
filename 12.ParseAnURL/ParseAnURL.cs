using System;
using System.Text;
//12.Write a program that parses an URL address given in the format:

        //and extracts from it the [protocol], [server] and [resource] elements. For example from the URL http://www.devbg.org/forum/index.php the following information should be extracted:
        //[protocol] = "http"
        //[server] = "www.devbg.org"
        //[resource] = "/forum/index.php"

class ParseAnURL
{
    static void Main()
    {
        string url = "http://forums.academy.telerik.com/52798/c%23-%D0%B4%D0%BE%D0%BC%D0%B0%D1%88%D0%BD%D0%BE-numeral-systems-4-%D0%B7%D0%B0%D0%B4%D0%B0%D1%87%D0%B0?show=141457#a141457";
        int protocolEnd = url.IndexOf(':');
        StringBuilder protocol = new StringBuilder();
        for (int i = 0; i < protocolEnd; i++)
        {
            protocol.Append(url[i]);
        }
        int serverStart = protocolEnd + 3;
        int serverEnd = url.IndexOf('/', serverStart);
        StringBuilder server = new StringBuilder();
        for (int i = serverStart; i < serverEnd; i++)
        {
            server.Append(url[i]);
        }
        StringBuilder resource = new StringBuilder();
        for (int i = serverEnd; i < url.Length; i++)
        {
            resource.Append(url[i]);
        }
        Console.WriteLine("[protocol]={0}", protocol.ToString());
        Console.WriteLine("[server]={0}", server.ToString());
        Console.WriteLine("[resource]={0}", resource.ToString());
    }
}
