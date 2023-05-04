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
                Console.WriteLine("Welcome to the program tutorial!");
                Console.WriteLine("");
                Console.WriteLine("Upon selecting the Maths Question Generator. The program will randomly generate 2 numbers and an operator.");
                Console.WriteLine("This is then presented to the user as a question. An example might look like:");
                Console.WriteLine("");
                Console.WriteLine("What is...");
                Console.WriteLine("5 + 7?");
                Console.WriteLine("");
                Console.WriteLine("It is then your turn to enter the number you think is the solution!");
                Console.WriteLine("Once you do this, one of two things will happen. The application will either tell you that you got the answer correct");
                Console.WriteLine("or wrong.");
                Console.WriteLine("");
                Console.WriteLine("Don't be disheartened if you get a few wrong to begin with! Maths can be tricky!");
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
                Console.Clear();
                Card.Main(args);
                }
            }
        }
    

        