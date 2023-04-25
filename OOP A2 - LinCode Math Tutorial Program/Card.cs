using OOP_A2___LinCode_Math_Tutorial_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A2___LinCode_Math_Tutorial_Program
{
    internal class Card
    {
        static void Main(string[] args)
        {
            bool validInput = true;
            string userInput = null;
            
            Console.WriteLine("Welcome to LinCode's Year 1 and 2 Maths tutoring program!");
            Console.WriteLine("");
            Console.WriteLine("Please Select one the following options to proceed by entering the corresponding number.");
            Console.WriteLine("");
            Console.WriteLine("1. Program Tutorial");
            Console.WriteLine("2. Beginner Question Difficulty");
            Console.WriteLine("3. Harder Question Difficulty");
            Console.WriteLine("4. Exit Application");
            Console.WriteLine("");


            userInput = Console.ReadLine();


            while (validInput == true)
            {
                if (userInput != "1" && userInput != "2" && userInput != "3" && userInput != "4")
                {
                    Console.WriteLine("Invalid input. The input must be 1, 2, 3, or 4.");
                    break;
                }
                else
                {
                    if (userInput == "1")
                    {

                        Tutorial.tutorialMain(args);
                        break;
                    }

                    if (userInput == "2")
                    {
                        break;
                        //Beginner Question Difficulty
                    }

                    if (userInput == "3")
                    {
                        break;
                        //Intermediate Difficulty
                    }

                    if (userInput == "4")
                    {
                        Console.WriteLine("Thank you for using our application and we hope you learned lots!"); //Exit Message
                        Environment.Exit(0); //Exits Application
                    }


                }
            }
            userInput = null;
        }


    }
}
