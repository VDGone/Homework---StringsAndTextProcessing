using System;
using System.Globalization;
using System.Threading;

namespace _17.DateInBulgarian
{
    class DateInBulgarian
    {
        static void Main(string[] args)
        {
            //Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the 
            //date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

            CultureInfo culture = new CultureInfo("bg-BG");
            DateTime now = DateTime.Now;
            DateTime newDate = now;
            newDate = now.AddHours(6).AddMinutes(30);
            
            Console.WriteLine("Time now - {0}\nAfter 6 hours and 30minutes - {1}\nDate - {2}", now, newDate, culture.DateTimeFormat.GetDayName(newDate.DayOfWeek));
        }
    }
}
