using System;
using System.Collections.Generic;
using System.Text;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

            Console.WriteLine("Enter text with palindromes: ");
            string inputText = Console.ReadLine();
            string[] userText = inputText.Split(' ');

            string reverseText = string.Empty;

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                reverseText += inputText[i];
            }
            
            string[] reverse = reverseText.Split(' ');
            Array.Reverse(reverse);

            for (int i = 0; i < userText.Length; i++)
            {
                if (userText[i] == reverse[i])
                {
                    Console.WriteLine("Palindromes: {0}", userText[i]);
                }
            }
        }
    }
}
