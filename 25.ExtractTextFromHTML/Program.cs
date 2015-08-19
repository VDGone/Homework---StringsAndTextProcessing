using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _25.ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
            Console.WriteLine("Enter text");
            string inputText = Console.ReadLine();
            string result = string.Empty;

            foreach (Match text in Regex.Matches(inputText, "(?<=>).*?(?=<)"))
            {
                if (!string.IsNullOrWhiteSpace(text.Value))
                {
                    result += text;
                }
            }
            Console.WriteLine("Output: {0}", result);
        }
    }
}
