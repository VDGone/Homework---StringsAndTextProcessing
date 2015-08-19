using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            //Write a program to check if in a given expression the brackets are put correctly.
            //Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b))

            Console.WriteLine("Enter expresion: ");
            string expresion = Console.ReadLine();
            int countOpenBracket = 0;
            int countClosedBracket = 0;

            for (int i = 0; i < expresion.Length; i++)
            {
                if (countClosedBracket > countOpenBracket)
                {
                    break;
                }
                else if (expresion[i] == '(')
                {
                    countOpenBracket++;
                }
                else if (expresion[i] == ')')
                {
                    countClosedBracket++;
                }
            }
            if (countOpenBracket == countClosedBracket)
            {
                Console.WriteLine("Your expression is valid!");
            }
            else
            {
                Console.WriteLine("Your expression is invalid!");
            }
        }
    }
}
