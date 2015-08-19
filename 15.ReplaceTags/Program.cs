using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.ReplaceTags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            //Write a program that replaces in a HTML document given as string 
            //all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
            Console.WriteLine("Enter HTML document: ");
            string htmlInput = Console.ReadLine();

            string html1 = "<a href=\"";
            string html2 = @""">";
            string html3 = "</a>";
            string url1 = "[URL=";
            string url2 = "]";
            string url3 = "[/URL]";

            while (htmlInput.Contains(html1))
            {
                htmlInput = htmlInput.Replace(html1, url1);
            }
            while (htmlInput.Contains(html2))
            {
                htmlInput = htmlInput.Replace(html2, url2);
            }    
            while (htmlInput.Contains(html3))
            {
                htmlInput = htmlInput.Replace(html3, url3);
            }
                Console.WriteLine("Replaced text:\n{0}",htmlInput);
        }
    }
}
