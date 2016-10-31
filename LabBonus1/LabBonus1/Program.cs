using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabBonus1
{
    class Program
    {
        static void Main(string[] args)

        {


            Console.WriteLine("Welcome to the Letter Grade Converter!");

            
            string inputYes = "y";
            do
            {
                Console.WriteLine("Enter a numerical grade:");
                int numericGrade = int.Parse(Console.ReadLine());
               
                if (numericGrade >= 88 && numericGrade <= 100)
                {
                    string letterGrade = "A";
                    Console.WriteLine("Letter Grade:" + letterGrade);
                  //  Console.WriteLine("Continue? (y/n):");
                }
                else if (numericGrade >= 80 && numericGrade <= 87)
                {
                    string letterGrade = "B";
                    Console.WriteLine("Letter Grade:" + letterGrade);
                   // Console.WriteLine("Continue? (y/n):");
                }
                else if (numericGrade >= 67 && numericGrade <= 79)
                {
                    string letterGrade = "C";
                    Console.WriteLine("Letter Grade:" + letterGrade);
                   // Console.WriteLine("Continue? (y/n):");
                }

                else if (numericGrade >= 60 && numericGrade <= 66)
                {
                    string letterGrade = "D";
                    Console.WriteLine("Letter Grade:" + letterGrade);
                  //  Console.WriteLine("Continue? (y/n):");

                }

                else
                {
                    string letterGrade = "F";
                    Console.WriteLine("LetterGrade:" + letterGrade);
                }
                Console.WriteLine("Continue? (y/n):");
                inputYes = Console.ReadLine();

            } while (inputYes == "y");
        }
    }
}
