using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This is my first C# program
namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number"); //This will print a message;


            string input = Console.ReadLine();

            //  int number = Convert.ToInt32(input);
            int number = int.Parse(input);

            number = number + 2;

            Console.WriteLine(number);

        }
    }
}
