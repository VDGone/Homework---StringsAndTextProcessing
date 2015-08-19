using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string, reverses it and prints the result at the console.

            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            StringBuilder reverseText = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText.Append(text[i]);
            }
            Console.WriteLine("Your reversed text is: {0}", reverseText);
        }
    }
}
