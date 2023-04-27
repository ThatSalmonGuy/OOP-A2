﻿using OOP_A2___LinCode_Math_Tutorial_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OOP_A2___LinCode_Math_Tutorial_Program
{
    public abstract class Card : Pack
    {
        static public void Main(string[] args)
        {
            ShowMainMenu(args);
        }

        static void ShowMainMenu(string[] args)
        {
            Console.WriteLine("Welcome to LinCode's Year 1 and 2 Maths tutoring program main menu!");
            Console.WriteLine("");
            Console.WriteLine("Please Select one the following options to proceed by entering the corresponding number.");
            Console.WriteLine("");
            Console.WriteLine("1. Program Tutorial");
            Console.WriteLine("2. Maths Question Generator");
            Console.WriteLine("3. Exit Application");
            Console.WriteLine("");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Tutorial.TutorialMain(args);
                    break;

                case "2":
                    MathsQuestionGenerator(args);
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. The input must be 1, 2, 3, or 4.");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to return to main menu");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    ShowMainMenu(args);
                    break;
            }
        }

        static void ShowTutorial(string[] args)
        {
            Console.Clear();
            Tutorial.TutorialMain(args);
            ShowMainMenu(args);
        }

        static void MathsQuestionGenerator(string[] args)
        {
            Console.Clear();
            Pack card = new Pack();
            int randomNumOne = card.NumberGeneratorOne(); //tests the ability to call the first number generator from Pack
            int randomNumTwo = card.NumberGeneratorTwo(); //tests the ability to call the second number generator from Pack
            string randomOperationOne = card.OperationGeneratorOne();

            int correctAnswer = 0;

            switch (randomOperationOne)
            {
                case "+":
                    correctAnswer = randomNumOne + randomNumTwo;
                    break;
                case "-":
                    correctAnswer = randomNumOne - randomNumTwo;
                    break;
                case "/":
                    correctAnswer = randomNumOne / randomNumTwo;
                    break;
                case "*":
                    correctAnswer = randomNumOne * randomNumTwo;
                    break;
            }

            Console.WriteLine("What is...");
            Console.WriteLine(randomNumOne + "" + randomOperationOne + "" + randomNumTwo + "?");
            Console.WriteLine("");

            string userAnswer = Console.ReadLine();
            string correctAnswerString = correctAnswer.ToString();

            if (userAnswer == correctAnswerString)
            {
                Console.Clear();
                Console.WriteLine("Correct answer! Congratulations!");
                Console.WriteLine("");
                Console.WriteLine("1. New Question");
                Console.WriteLine("2. Exit to main menu");
                Console.WriteLine("");

                string continueOrMenuInput = Console.ReadLine();

                while (true)
                {
                    if (continueOrMenuInput == "1")
                    {
                        MathsQuestionGenerator(args);
                        break;
                    }
                    else if (continueOrMenuInput == "2")
                    {
                        Console.Clear();
                        ShowMainMenu(args);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input of 1 or 2");
                        Console.WriteLine("");
                        continueOrMenuInput = Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Unfortunately that is the incorrect answer!");
                Console.WriteLine("");
                Console.WriteLine("Press 1 for a new question");
                Console.WriteLine("Press 2 to return to main menu");
                Console.WriteLine("");

                string continueOrMenuInput = Console.ReadLine();

                while (true)
                {
                    if (continueOrMenuInput == "1")
                    {
                        MathsQuestionGenerator(args);
                        break;
                    }
                    else if (continueOrMenuInput == "2")
                    {
                        Console.Clear();
                        ShowMainMenu(args);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid input of 1 or 2");
                        Console.WriteLine("");
                        continueOrMenuInput = Console.ReadLine();
                    }
                }

            }
        }

       
        }
    }

