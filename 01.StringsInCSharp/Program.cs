using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.StringsInCSharp
{
    class StringInCSharp
    {
        static void Main(string[] args)
        {
            //A string is an object of type String whose value is text.
            //Internally, the text is stored as a sequential read-only collection of Char objects.
            //There is no null-terminating character at the end of a C# string;
            //therefore a C# string can contain any number of embedded null characters.
            //The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters.
            //
            //The String class has numerous methods that help you in working with the string objects.

            //Compare determines the sort order of strings. It checks if one string is ordered before another when in alphabetical order,
            //whether it is ordered after, or is equivalent. Compare, CompareOrdinal and CompareTo provide this functionality.

            //The string.Empty field is an empty string literal. It is slightly different from an empty string literal constant "".

            //String.Format creates strings from a pattern and values. It is a static method.
            //It receives a format string that specifies where the following arguments should inserted.

            //IndexOf. A string contains many characters. These characters may be searched and tested.
            //We simplify these operations with IndexOf.

            //The string.Join method combines many strings into one. It receives two arguments: an array or IEnumerable 
            //and a separator string. It places the separator between every element of the collection in the returned string.

            //Every string object has a length. Every character—no matter what it is—is counted in the Length property. 

            //Remove eliminates a range of characters. The Remove method on the string class is useful for shortening strings. 

            //Replace. A string contains incorrect chars. It has XYZ but we want ABC. Replace helps with this puzzle. It swaps those substrings.

            //A string method, Split() separates at string and character delimiters. 
            //Even if we want just one part from a string, Split is useful. It returns a string array.

            //Substring. This method extracts strings. It requires the location of the substring (a start index, a length). 
            //It then returns a new string with the characters in that range.

            //ToCharArray converts strings to character arrays. It is called on a string and returns a new char array.

            //ToLower changes strings to be all lowercase. It converts an entire string—without changing letters that are 
            //already lowercased or digits. It copies a string and returns a reference to the new string. 
            //The original string is unchanged.

            //ToUpper uppercases all letters in a string. It is useful for processing text input
            //or for when you need to check the string against an already uppercase string.

            //ToString is virtual. It returns a string representation. We must override ToString on custom types for the method to be effective. 
            //For numeric types, there are performance and functional differences with ToString.

            //Trim eliminates leading and trailing whitespace. We need to remove whitespace from the beginning or ending of a string. 
            //We use the .NET Framework's Trim method to do this efficiently. This method removes any characters specified.
        }
    }
}
