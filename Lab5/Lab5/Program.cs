using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int die1 = 0;
            int die2 = 0;
            Console.Write("Welcome to the Grand Circus Casino! Roll the dice? (y/n) :");
            string yes = Console.ReadLine();
            
            if (yes == "y" || yes == "Y")
            {
                Console.WriteLine(" Please enter the number of sides for a pair of dice.");
                int numberOfFaces = int.Parse(Console.ReadLine());
                Console.WriteLine("Roll 1: ");
                Random r = new Random();
                for (int i = 0; i <= numberOfFaces; i++)
                {
                    die1 = r.Next(1,7);
                    die2 = r.Next(1, 7);
                    Console.WriteLine(die1);
                    Console.WriteLine(die2);
                    Console.Write("Roll again? (y/n): ");
                    Console.ReadLine();
                }
                

           }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}
