using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStatement1
{
    class Program
    {
        static void Main(string[] args)


        {
            
            int input = 0;
            input = int.Parse(Console.ReadLine());
            switch (input)

            {
                case 1:
                    Console.WriteLine("You selected 1");
                    break;

                case 2:
                    Console.WriteLine("You selected 2");
                    break;

                case 3:

                    Console.WriteLine("You selected 3");
                    break;
                case 4:

                    Console.WriteLine("Default case");
                    break;

            }

              






        }
    }
}
