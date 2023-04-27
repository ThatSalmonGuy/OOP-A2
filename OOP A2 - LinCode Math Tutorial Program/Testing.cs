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
    public class Testing
    {

        public void Tests(string[] args)
        {
        start:
            Console.WriteLine("Press 1 to test number generators + ability to generate equation in the form of text");
            //for more tests later

            string testInput = Console.ReadLine();

            
            if (testInput == "1")
            {
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
                        correctAnswer = randomNumOne - randomNumTwo;
                        break;
                }

                Console.WriteLine("What is...");
                Console.WriteLine(randomNumOne + "" + randomOperationOne + "" + randomNumTwo + "?");

                string userAnswer = Console.ReadLine();
                string correctAnswerString = correctAnswer.ToString();

                if (userAnswer == correctAnswerString)
                {
                    Console.WriteLine("Correct answer!");
                }

                Console.ReadLine();
                
                Console.Clear();
                goto start;

            }
        }
    }
}
