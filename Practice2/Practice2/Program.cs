using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;
            input = int.Parse(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("You selected 1");
            }
            else if (input == 2)
            {
                Console.WriteLine("You selected 2");
            }
            else if (input == 3)
            {
                Console.WriteLine("You selected 3");
            }
            else
            {
                Console.WriteLine("Invalid Selection!");
            }
               
        }
    }
}
