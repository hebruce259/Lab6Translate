using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6TranslateToEnglish
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pig Latin Translator!");
            
            //Translate after user input here.
            Console.Write("Enter word to be translated:");
            string word = Console.ReadLine();
            string lowerCaseWord = word.ToLower();
            Console.WriteLine("{0}", lowerCaseWord);
            //Convert to lowercase here.
          //  Console.WriteLine(word);
        }
    }
}
