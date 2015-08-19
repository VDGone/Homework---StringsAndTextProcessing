using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            //Write a program that converts a string to a sequence of C# Unicode character literals.
            //Use format strings.

            Console.WriteLine("Enter text");
            string text = Console.ReadLine();

            StringBuilder unicodeChar = new StringBuilder();
            foreach (char ch in text)
            {
                unicodeChar.Append("\\u");
                unicodeChar.Append(String.Format("{0:x4}", (int)ch));
            }
            Console.WriteLine(unicodeChar);
        }
    }
}
