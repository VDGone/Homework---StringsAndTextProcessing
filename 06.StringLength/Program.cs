using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a string of maximum 20 characters.
            //If the length of the string is less than 20, the rest of the characters should be filled with *.
            //Print the result string into the console.

            Console.WriteLine("Enter text with max length 20 characters");
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder(text);

            if (text.Length > 20)
            {
                Console.WriteLine("Enter shorter text!");
            }
            else
            {
                for (int i = 0; i < 20 - text.Length; i++)
                {
                    result.Append("*");
                }
                Console.WriteLine(result);
            }
        }
    }
}
