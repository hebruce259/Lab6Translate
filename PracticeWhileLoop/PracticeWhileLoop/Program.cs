using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            string PlayGame = "yes";
            while (PlayGame == "yes")
            
            {
                //do something
                Console.WriteLine("Do you want to continue?");
                PlayGame = Console.ReadLine();
                //do this because you do not know how many times user wants to play

            }
        }
    }
}
