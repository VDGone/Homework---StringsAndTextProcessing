using System;
using System.Text.RegularExpressions;

namespace _18.ExtractE_mails
{
    class E_mails
    {
        static void Main(string[] args)
        {
            //Write a program for extracting all email addresses from given text.
            //All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

            Console.WriteLine("Enter text with email inside: ");
            string inputText = Console.ReadLine().Trim();

            foreach (var item in Regex.Matches(inputText, @"\w+@\w+\.\w+"))
            {
                Console.WriteLine("E-mail - {0}", item);
            }
        }
    }
}

