using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace OOP_A2___LinCode_Math_Tutorial_Program
{
    public class Pack
    {
        
        public int NumberGeneratorOne()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            int randomNumber = array[0];
            //Console.WriteLine(randomNumber); // used for testing
            return randomNumber;


        }

        public int NumberGeneratorTwo()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            int randomNumber = array[1];
            //Console.WriteLine(randomNumber); // used for testing
            return randomNumber;

        }

        /*public int NumberGeneratorThree()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            int randomNumber = array[2];
            return randomNumber;

        }*/

        public string OperationGeneratorOne()
        {
            string[] array = { "+", "-", "/", "*" };
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            
            string randomOperation = array[0];
            //Console.WriteLine(randomOperation); // used for testing
            return randomOperation;

        }

        /*public string OperationGeneratorTwo()
        {
            string[] array = { "+", "-", "/", "*" };
            Random random = new Random();

            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            string randomOperation = array[1];
            return randomOperation;

        }*/

    }
}
