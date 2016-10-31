using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2CeateaStory
{
    class Program
    {
        static void Main(string[] args)
        {
            
          //  string faceTheBeast = "";
            Console.WriteLine("Welcome! What is your Name????" );
            string Name = Console.ReadLine();
            Console.WriteLine("Hi " + Name);
            Console.WriteLine("Would you like to play game?");
            string gamePlay = Console.ReadLine();
            if (gamePlay == "yes" || gamePlay == "Yes" || gamePlay == "YES" || gamePlay == "Y" || gamePlay == "y")
            {
                Console.WriteLine("Excellent!");
                Console.WriteLine("You are walking across a field and you encounter a fire-breathing dragon!");
                Console.WriteLine("Do you Face the Beast or Run?");
                string userInput =Console.ReadLine();
                if( userInput == "face the beast" || userInput == "Face the beast" || userInput == "Face the Beast" || userInput == "FACE THE BEAST")
                {
                    Console.Write("You approach the dragon. You see that he has ____ heads. (enter 1 or 2 or 3: ");
                    int numberOfHeads = int.Parse(Console.ReadLine());
                    if (numberOfHeads == 3)
                    {
                        Console.WriteLine("No one has ever faced a 3 headed dragon before! Choose your weapon. (enter sling shot or sword or bow and arrow: ");
                        string Weapon = Console.ReadLine();
                        Console.WriteLine("Armed with your " + Weapon + " You approach the dragon.  You can feel its fiery breath as you get closer.");
                        Console.WriteLine("It stares at you with its ___ eyes. (enter red or blue: )");
                        string colorEyes = Console.ReadLine();
                        Console.WriteLine(colorEyes);

                        if (colorEyes== "Blue" || colorEyes == "blue"|| colorEyes =="BLUE")
                        {
                            Console.WriteLine("You have met up with a blue eyed dragon! Run for your Life!!!");

                        }
                        else
                        {
                            Console.WriteLine(" Oh thank goodness! Red-eyed dragons are friendly.  You pet it and you both become friends");
                            Console.Write("You name the dragon ____(enter a name): ");
                            string dragonName = Console.ReadLine();
                            Console.WriteLine(Name +" and "+ dragonName + " Live Happily ever after!");
                            
                        }
                    }
                    else
                    {
                        Console.WriteLine("You're lucky you didn't run into the 3 headed dragon!!!");
                        Console.ReadLine();
                    }

                }

            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
            
          }
    }
}
