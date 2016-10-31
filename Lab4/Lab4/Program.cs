using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.Write("Please enter an integer from 1 to 10: ");
            int CalculateFactorial = 1;
            int UserInputNum = int.Parse(Console.ReadLine());
            

            for (int i= 2; i <= UserInputNum; i++)
            {
                //User will input a number
                CalculateFactorial = CalculateFactorial * i;

                
                
            }
            Console.WriteLine(CalculateFactorial);
            Console.WriteLine("Conitinue? Yes or No?");

           
        }
    }
}
