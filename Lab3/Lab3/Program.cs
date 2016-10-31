using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer");
            int inputInteger = int.Parse(Console.ReadLine());

            Console.WriteLine("Number      Squared         Cubed ");  
            for (int i = 1; i <= inputInteger; i++)
            {
                Console.Write((i.ToString()).PadRight(15));
                //Console.Write(i * i + "          ");
                Console.Write(((i * i).ToString()).PadRight(15));
                // Console.Write(i * i * i + "          ");
                //Console.Write((((i * i * i).ToString()).PadRight(15)));
                Console.Write((((Math.Pow(i,3)).ToString()).PadRight(15)));
                
                Console.WriteLine();
            }
        }
    }
}
