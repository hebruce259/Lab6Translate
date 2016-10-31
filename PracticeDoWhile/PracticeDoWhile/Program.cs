using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDoWhile
{
    class Program
    {
        static void Main(string[] args)
        { string PlayGame = "yes";
            do
            {
                Console.WriteLine("Do you want to continue?");
            } while (PlayGame =="yes");
        }
    }
}
