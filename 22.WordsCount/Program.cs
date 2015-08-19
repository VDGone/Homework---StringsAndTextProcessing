using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class WordsCount
    {
        static void Main(string[] args)
        {
            //Write a program that reads a string from the console and lists all different 
            //words in the string along with information how many times each word is found.

            Console.WriteLine("Enter text");
            string inputText = Console.ReadLine().Trim().ToLower();
            string[] text = inputText.Split(' ', ',', '.', '!', '?');

            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            foreach (var word in text)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 1);
                }
                else
                {
                    wordCounts[word]++;
                }
            }
            var list = wordCounts.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine("Word \"{0}\" - {1}times.", key, wordCounts[key]);
            }
        }
    }
}


