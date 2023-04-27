using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A2___LinCode_Math_Tutorial_Program
{
    public abstract class Tutorial
    {
        

        static public void TutorialMain(string[] args)
        {
            Console.Clear();
            Tutorial.TutorialMenu(args);
      
        }

        static public void TutorialMenu(string[] args)
        {

            bool validInput = true;

            while (validInput == true)
            {
            
                Console.Clear();
                Console.WriteLine("Welcome to the program tutorial!");
                Console.WriteLine("");
                Console.WriteLine("Please enter the number corresponding to the tutorial you would like to receive.");
                Console.WriteLine("");
                Console.WriteLine("1. Program navigation.");
                Console.WriteLine("2. Maths Question Generator Tutorial");
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("");

                string userInput = null;
                userInput = Console.ReadLine();

                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
                {
                    Console.WriteLine("Invalid input. The input must be 1, 2, 3, or 4.");
                    break;
                }
                else
                {
                    if (userInput == "1")
                    {                       
                        Console.Clear();
                        Console.WriteLine(                       "Welcome to the navigation tutorial!");
                        Console.WriteLine("In order to navigate the program, you will need to enter the number corresponding");
                        Console.WriteLine("to the option you would like to select when presented with a menu or selection option.");
                        Console.WriteLine("");
                        Console.WriteLine("These options will be clearly labeled in the manner provided in the example below.");
                        Console.WriteLine("");
                        Console.WriteLine(                       "1. Program Tutorial");
                        Console.WriteLine(                       "2. Maths Question Generator");
                        Console.WriteLine(                       "3. Exit Application");
                        Console.WriteLine("");
                        Console.WriteLine("For example, if you were to type in the number 2 you would be brought to the Maths Question Generator.");
                        Console.WriteLine("");
                        Console.WriteLine("We hope this has helped. Please press any character and enter to return to the tutorial menu.");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Tutorial.TutorialMain(args);
                    }

                    if (userInput == "2")
                    {                        
                        Console.Clear();
                        Console.WriteLine("Welcome to the Maths Question Generator tutorial!");
                        Console.WriteLine("Upon selecting the Maths Question Generator. The program will randomly generate 2 numbers and an operator.");
                        Console.WriteLine("This is then presented to the user as a question. An example might look like:");
                        Console.WriteLine("");
                        Console.WriteLine("What is...");
                        Console.WriteLine("5 + 7?");
                        Console.WriteLine("");
                        Console.WriteLine("It is then your turn to enter the number you think is the solution!");
                        Console.WriteLine("Once you do this, one of two things will happen. The application will either tell you that you got the answer correct or wrong.");
                        Console.WriteLine("");
                        Console.WriteLine("Don't be dishearted if you get a few wrong to begin with! Maths can be tricky!");
                        Console.WriteLine("");
                        Console.WriteLine("Once you know whether you've got the answer correct or not, the computer will present you with two options.");
                        Console.WriteLine("The 1st option you'll have is to generate a brand new randomly generated Maths question to try out your Maths skills on!");
                        Console.WriteLine("(We highly recommend this option!)");
                        Console.WriteLine("Your second option is to exit to the main menu.");
                        Console.WriteLine("Tips on navigating these options can be found in the Program navigation tutorial!");
                        Console.WriteLine("");
                        Console.WriteLine("We hope this has helped. Please press any character and enter to return to the tutorial menu.");
                        Console.WriteLine("");
                        Console.ReadLine();
                        Tutorial.TutorialMain(args);
                    }

                    if (userInput == "3")
                    {                        
                        Console.Clear();
                        Card.Main(args);
                    }

                }
            }
        }
    }
}
        