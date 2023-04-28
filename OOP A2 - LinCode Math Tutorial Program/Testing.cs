using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace OOP_A2___LinCode_Math_Tutorial_Program
{
    public class Testing : Card
    {
        public void TestingMain(string[] args)
        {
            Console.Clear();
            Console.Write("Please enter the appropriate number corresponding to the function you would like to test or to exit.");
            Console.WriteLine("1. Main Class functionality");
            Console.WriteLine("2. Main Menu functionality");
            Console.WriteLine("3. Main Menu Tutorial selection functionality");
            Console.WriteLine("4. Question generator functionality");
            Console.WriteLine("5. Exit program functionality");
            Console.WriteLine("6. Tutorial Classes Main functionality");
            Console.WriteLine("7. Number Generator One functuionality");
            Console.WriteLine("8. Number Generator Two functionality");
            Console.WriteLine("9. Operator Generator functionality.");
            Console.WriteLine("10. Exit Application.");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    TestsMain(args);
                    break;
                case "2":
                    TestsShowMainMenu(args);
                    break;
                case "3":
                    TestsTutorialMenu(args);
                    break;
                case "4":
                    TestsQuestionGenerator(args);
                    break;
                case "5":
                    TestsExitFunction(args);
                    break;
                case "6":
                    TestsTutorial(args);
                    break;
                case "7":
                    TestsRandomNumberGeneratorOne(args);
                    break;
                case "8":
                    TestsRandomNumberGeneratorTwo(args);
                    break;
                case "9":
                    TestsRandomOperationGeneratorOne(args);
                    break;
                case "10":
                    Environment.Exit(0);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Invalid input. The input must be 1, 2, 3, or 4.");
                    Console.WriteLine("");
                    Console.WriteLine("Press any key to return to testing main menu");
                    Console.WriteLine("");
                    Console.ReadLine();
                    Console.Clear();
                    TestingMain(args);
                    break;

            }

        }
        

        public void TestsMain(string[] args)
        {
            Main(args);
        }

        public void TestsShowMainMenu(string[] args)
        {
            ShowMainMenu(args);
        }

        public void TestsTutorialMenu(string[] args)
        {
            ShowTutorial(args);
        }

        public void TestsQuestionGenerator(string[] args)
        {
            MathsQuestionGenerator(args);
        }

        public void TestsExitFunction(string[] args)
        {
            MathsQuestionGenerator(args);
        }
        public void TestsTutorial(string[] args)
        {
            Tutorial.TutorialMain(args);
        }
        public void TestsRandomNumberGeneratorOne(string[] args)
        {
            Pack testing = new Pack();
            testing.NumberGeneratorOne();
        }

        public void TestsRandomNumberGeneratorTwo(string[] args)
        {
            Pack testing = new Pack();
            testing.NumberGeneratorTwo();
        }
        public void TestsRandomOperationGeneratorOne(string[] args)
        {
            Pack testing = new Pack();
            testing.OperationGeneratorOne();
        }

    }


}
