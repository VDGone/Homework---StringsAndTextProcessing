using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and replaces all 
            //series of consecutive identical letters with a single one.

            Console.WriteLine("Enter text");
            string inputText = Console.ReadLine();
            int index = 0;
             
            StringBuilder lettersBuild = new StringBuilder();

            for (int i = 1; i < inputText.Length; i++)
            {
                char letter = inputText[index];
                char nextLetter = inputText[i];
                if (letter != nextLetter)
                {
                    lettersBuild.Append(letter);
                    index = i;
                }
                if (i == inputText.Length - 1)
                {
                    lettersBuild.Append(nextLetter);
                }
            }
            Console.WriteLine("Result: {0}", lettersBuild);
        }
    }
}
