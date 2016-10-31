using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args) { 
           string inputYes = "y";

         do
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            Console.WriteLine("Enter Length:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Width:");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            Console.WriteLine("The total Area =" + area);

            double perimeter = 2 * length + 2 * width;

            Console.WriteLine("The total Perimeter =" + perimeter);


            Console.WriteLine("Continue? (y/n):");

            inputYes = Console.ReadLine();

        }
        while (inputYes == "y");



      }

    }
}
