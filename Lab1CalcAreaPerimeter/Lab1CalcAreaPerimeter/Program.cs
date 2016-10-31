using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1CalcAreaPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            int Lengthout = 0;
            int Widthout = 0;
            int Area = 0;
            int Perimeter = 0;
            string Yes = "y";
          //  string No = "n";

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            Console.Write("Enter Length: ");
            String Lengthin = Console.ReadLine();
            Console.Write("Enter Width: ");
            String Widthin = Console.ReadLine();

            Lengthout = Convert.ToInt32(Lengthin);
            Widthout = Convert.ToInt32(Widthin);
            
            //Calculate Area here
            Area = Lengthout * Widthout;
            Console.WriteLine("Total Area: " + Area);

            //Calculate Perimeter here
            Perimeter = 2 * Lengthout + 2 * Widthout;
            Console.WriteLine("Total Perimeter: " + Perimeter);
            Console.Write("Continue? (y/n): ");
            Console.ReadLine();
            if (Yes == "y" || Yes == "Y" || Yes == "yes" || Yes == "Yes")
            {
                Console.Write("Enter Length: ");
                Lengthin = Console.ReadLine();
                Console.Write("Enter Width: ");
                Widthin = Console.ReadLine();

                Lengthout = Convert.ToInt32(Lengthin);
                Widthout = Convert.ToInt32(Widthin);

                //Calculate Area here
                Area = Lengthout * Widthout;
                Console.WriteLine("Total Area: " + Area);

                //Calculate Perimeter here
                Perimeter = 2 * Lengthout + 2 * Widthout;
                Console.WriteLine("Total Perimeter: " + Perimeter);
                Console.Write("Continue? (y/n): ");
                Console.ReadLine();
         
            }
            
            
           
        }
    }
}
