using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24.OrderWords
{
    class OrderWords
    {
        static void Main(string[] args)
        {
            //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

            
            Console.WriteLine("Enter words separated by spaces: ");
            string inputText = Console.ReadLine().Trim().ToLower();
            string[] text = inputText.Split(' ');

            var sortedWords = from s in text
                              orderby s
                              select s;

            foreach (string word in sortedWords)
            {
                Console.WriteLine("Sorted words: {0}", word);
            }
        }
    }
}
