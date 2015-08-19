using System;
using System.Globalization;
using System.Threading;

namespace _16.DateDifference
{
    class DateDifference
    {
        static void Main(string[] args)
        {
            //Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

            Console.WriteLine("Enter date (dd.mm.yyyy):");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter another date:");
            string secondDate = Console.ReadLine();

            DateTime parseFirstDate = DateTime.Parse(firstDate, new CultureInfo("bg-BG"));
            DateTime parseSecondDate = DateTime.Parse(secondDate, new CultureInfo("bg-BG"));

            if (parseFirstDate < parseSecondDate)
            {
                TimeSpan difference = parseSecondDate - parseFirstDate;
                Console.WriteLine("Number of days = {0}.", Math.Abs(difference.Days));
            }
            else
            {
                TimeSpan difference = parseFirstDate - parseSecondDate;
                Console.WriteLine("Number of days = {0}.", Math.Abs(difference.Days));
            }
            
        }
    }
}
