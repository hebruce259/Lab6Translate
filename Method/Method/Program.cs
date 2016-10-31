using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintOneToTen();

            int max = int.Parse(Console.ReadLine());
            PrintNumbers(max);

        }
       // static void PrintOneToTen()
        static void PrintNumbers(int Max)
        {
            for (int i = 1; i <= Max; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

