using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.EncodeDecode
{
    class EncodeDecodeString
    {
        //Write a program that encodes and decodes a string using given encryption key (cipher).
        //The key consists of a sequence of characters.
        //The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string 
        //with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter chiper: ");
            string cipher = Console.ReadLine();

            EncoderDecoder(EncoderDecoder(text, cipher), cipher);
        }

        static string EncoderDecoder(string inputText, string key)
        {
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < inputText.Length; i++)
            {
                text.Append((char)(inputText[i] ^ key[i % key.Length]));
            }
            Console.WriteLine(text.ToString());
            return text.ToString();
        }
    }
}

