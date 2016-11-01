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
         //   const string isVowel =  new string ("aeiou");
            Console.WriteLine("Welcome to Pig Latin Translator!");
            
            //User input here.
            Console.Write("Enter word to be translated:");

            //Convert to Lower Case.
            string word = Console.ReadLine();
            string lowerCaseWord = word.ToLower();
            string wordOut ="";
            
            Console.WriteLine("{0}", lowerCaseWord);

            //if the first letter is a vowel attach "way" to the ending.
            if (lowerCaseWord.StartsWith("a") || lowerCaseWord.StartsWith("e") || lowerCaseWord.StartsWith("i") || lowerCaseWord.StartsWith("o") || lowerCaseWord.StartsWith("u"))
            {
                Console.WriteLine(lowerCaseWord + "way");
            }
            else
            //It's a Consonant chop the beginning letter off and move to the back adding "ay" to the ending.
            {
                for (int i = 1; i < lowerCaseWord.Length; i++)
                {
                    wordOut = wordOut + lowerCaseWord[i];
                }
                wordOut = wordOut + lowerCaseWord[0];
                Console.WriteLine(wordOut + "ay");
            }

            
        }
    }
}
