using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialTDD
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static long calculateFactorial(int num)
        {

            {
                //  Console.WriteLine("Welcome!");
                //  Console.Write("Please enter an integer from 1 to 10: ");
                int CalculateFactorial = 1;
              //  int UserInputNum = int.Parse(Console.ReadLine());


                for (int i = 2; i <= num; i++)
                {
                    //User will input a number
                    CalculateFactorial = CalculateFactorial * i;



                }
                // Console.WriteLine(CalculateFactorial);
                // Console.WriteLine("Conitinue? Yes or No?");




                 return CalculateFactorial;
            }
        }
    }
}

    

