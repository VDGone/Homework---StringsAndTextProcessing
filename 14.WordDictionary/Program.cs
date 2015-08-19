using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            //A dictionary is stored as a sequence of text lines containing words and their explanations.
            //Write a program that enters a word and translates it by using the dictionary.

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();

            if (dictionary.ContainsKey(word))
            {
                string value = dictionary[word];
                Console.WriteLine(value);
            }
            if (!dictionary.ContainsKey(word))
            {
                Console.WriteLine("No such word in dictionary!");
            }
        }
    }
}
