using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FormatNumber
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number and prints it as a decimal number,
            //hexadecimal number, percentage and in scientific notation.
            //Format the output aligned right in 15 symbols.

            Console.WriteLine("Enter number: ");
            int inputNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal = {0,15:D}\nHex = {1,15:X}\nPercentage = {2,15:P}\nScientific notation = {3,15:E}", 
                inputNumber, inputNumber, inputNumber, inputNumber);

        }
    }
}
