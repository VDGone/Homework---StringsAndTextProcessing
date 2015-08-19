using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace _19.DatesFromTextInCanada
{
    class ExtractDatesFromText
    {
        static void Main(string[] args)
        {
            //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
            //Display them in the standard date format for Canada.

            Console.WriteLine("Enter text with dates(dd.MM.yyyy) to extract.");
            string text = Console.ReadLine();

            foreach (var extracted in Regex.Matches(text, @"\d{2}.\d{2}.\d{4}"))
            {
                string extractedToString = Convert.ToString(extracted);
                DateTime date = DateTime.ParseExact(extractedToString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }
        }
    }
}

