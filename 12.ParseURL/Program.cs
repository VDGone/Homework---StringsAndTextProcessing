using System;
using System.Text.RegularExpressions;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            // Write a program that parses an URL address given in the format: 
            //[protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.

            Console.WriteLine("Enter URL: ");
            string url = Console.ReadLine();

            var fragments = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;

            Console.WriteLine("[protocol] = {0}", fragments[1]);
            Console.WriteLine("[server] = {0}", fragments[2]);
            Console.WriteLine("[resource] = {0}", fragments[3]);
        }
    }
}
