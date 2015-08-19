using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and prints all different 
            //letters in the string along with information how many times each letter is found.

            Console.WriteLine("Enter text");
            string text = Console.ReadLine().Trim().ToLower();
            char[] lettersArr = new char[123];

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsLetter(text[i]))
                {
                    lettersArr[text[i]]++;
                }
            }

            for (int i = 0; i < lettersArr.Length; i++)
            {
                if (lettersArr[i] > 0 && char.IsLetter((char)i))
                {
                    Console.WriteLine("Letter \"{0}\" - {1} times", (char)i, (int)lettersArr[i]);
                }
            }
        }
    }
}
