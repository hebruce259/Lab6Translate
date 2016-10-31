using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        { //string str = string.Concat("Hello", " World"); //Hello World
          //Console.WriteLine(str);
          // string input = Console.ReadLine();

            //Console.WriteLine(input.IndexOf('e'));
            // Console.WriteLine("Welcome to the Pig Latin Translator");
            //Console.Write("Enter a line to be translated: ");

            //string input=Console.ReadLine();
            //Console.WriteLine(input + "way");

            // Input string.
            //string mixedCase = "This is a MIXED case string.";

            // Call ToLower instance method, which returns a new copy.
            //string lower = mixedCase.ToLower();

            // Display results.
            //Console.WriteLine("{0}, {1}",
            //   mixedCase,
            //   lower);

            string vowels = "aeiou";
            //string test = "";

            bool isVowel = vowels.Contains("aeiou");
            string test = Console.ReadLine();
            if (test == "a" || test == "e" || test == "i" || test== "o" ||test== "u")
            {
                Console.WriteLine(test);

            }
        }
    }
}
