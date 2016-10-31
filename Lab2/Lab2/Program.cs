using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("What is your name?");
           string input = Console.ReadLine();
            

            Console.WriteLine("Would you like to play a game? enter yes or no.");
            string yes = Console.ReadLine();

            //string yes = Console.ReadLine();
            int state = int.Parse(Console.ReadLine());
          
            while (yes) ;

            switch (state)
            {
               case 1:
                    Console.WriteLine("What is your name?");
                    string input = Console.ReadLine();

               break;

               case 2:
                    Console.WriteLine("Would you like to play a game? enter yes or no.");
                    Console.ReadLine();
                    
                    break;
                case 3:
                    Console.WriteLine("Excellent!");
                    break;
                                    
             }
        }
    }
}
