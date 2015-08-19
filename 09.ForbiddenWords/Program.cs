using System;
using System.Text.RegularExpressions;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            //We are given a string containing a list of forbidden words and a text containing some of these words.
            //Write a program that replaces the forbidden words with asterisks.
            //Example text:
            //Microsoft announced its next generation PHP compiler today. 
            //It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
            //Forbidden words: PHP, CLR, Microsoft
            //The expected result: ********* announced its next generation *** compiler today. 
            //It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.

            Console.WriteLine("Enter forbbiden words saparate by space: ");
            string forbiddenWords = Console.ReadLine();
            string[] wordsArr = forbiddenWords.Split(' ');

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();

            foreach (string word in wordsArr)
            {
                text = Regex.Replace(text, word, new String('*', word.Length));
            }

            Console.WriteLine("Result: \n{0}", text);
        }
    }
}
