using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sub_stringInText
{
    class SubstringIntText
    {
        static void Main(string[] args)
        {
            //Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
            //Example:
            //The target sub-string is in
            //The text is as follows: We are living in an yellow submarine. We don't have anything else. 
            //inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
            //The result is: 9

            Console.WriteLine("Enter text: ");
            string userText = Console.ReadLine().ToLower();

            Console.WriteLine("What word you want to find? ");
            string wantedWord = Console.ReadLine();
            int wordCount = 0;
            int tmpindex = 0;

            if (wantedWord.Length <= userText.Length)
            {
                for (int i = 0; i < userText.Length; i++)
                {
                    string word = userText.Substring(tmpindex, wantedWord.Length);
                    if (tmpindex + wantedWord.Length == userText.Length)
                    {
                        if (word == wantedWord)
                        {
                            wordCount++;
                        }
                        break;
                    }
                    if (word == wantedWord)
                    {
                        wordCount++;
                        tmpindex = i;
                    }
                    if (word != wantedWord)
                    {
                        tmpindex = i;
                    }
                }
                Console.WriteLine("The word \"{1}\" was found {0} times.", wordCount, wantedWord);
            }
            else
            {
                Console.WriteLine("Sub-string must be shorter than text!");
            }
        }
    }
}
