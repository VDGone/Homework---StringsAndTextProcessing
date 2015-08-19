using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all sentences containing given word.
            //Example:
            //The word is: in
            //The text is: We are living in a yellow submarine. We don't have anything else. 
            //Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
            //The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
            //Consider that the sentences are separated by . and the words – by non-letter symbols.

            Console.WriteLine("Enter text: ");
            string inputText = Console.ReadLine();
            string[] text = inputText.Split('.');
            Console.WriteLine("Given word: ");
            string wantedWord = Console.ReadLine();
            string result = string.Empty;

            foreach (string sentence in text)
            {
                string[] words = sentence.Split(new char[] { ' ', ',' });
                if (words.Contains(wantedWord))
                {
                    result = sentence;
                    Console.WriteLine(result.Trim() + '.');
                }
            }

        }
    }
}
