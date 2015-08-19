using System;
using System.Text.RegularExpressions;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main(string[] args)
        {
            //You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
            //The tags cannot be nested.
            //Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
            //The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
