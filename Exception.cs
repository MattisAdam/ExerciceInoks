using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.IO;
using System.Diagnostics;

namespace Exercice
{
    public class ExcerciceException1_13()
    {

        class NegativeNumberException : Exception
        {

            public NegativeNumberException(string message) : base(message)
            {
            }
        }

        public static void NegativeNumbercheck(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberException("Negative Number not allowed");
            }
        }


        public static void Exo1()
        {
            /*
             * Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.
             */
            Console.WriteLine("input two numbers and divides them.");
            int result = 0;
            int firstNumbers = 0;
            int secondNumbers = 0;
            try
            {
                Console.Write("first number ? ");
                firstNumbers = Fonction.EnterNumber();
                Console.Write("second number ? ");
                secondNumbers = Fonction.EnterNumber();
                Console.WriteLine($"Well done ! you enter {firstNumbers} and {secondNumbers}");
                result = firstNumbers / secondNumbers;
                Console.WriteLine($"the result is {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine(" ! ERROR ! Please retry to enter an integers");
                Exo1();
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine(" ! ERROR ! you cannot divide by zero");
            }



        }
        public static void Exo2()
        {
            /*
             * Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. Handle the exception in the calling code.
             */
            Console.WriteLine("takes an integer as input and throws an exception if the number is negative.");
            try
            {
                Console.Write("first number ? ");
                int firstNumbers = Convert.ToInt32(Console.ReadLine());
                NegativeNumbercheck(firstNumbers);
                Console.WriteLine($"Valid input {firstNumbers}");
            }

            catch (NegativeNumberException)
            {
                Console.WriteLine("Not a Negative Number please, retry");
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid input ");
            }
            catch (Exception)
            {
                Console.WriteLine(" !Error¨! unexpected  please retry");
            }




        }
        public static void Exo3()
        {
            /*
             * Write a C# program that reads a file path from the user and tries to open the file. Handle exceptions if the file does not exist.
             */
            Console.WriteLine("Input the filespath");
            try
            {
                using (StreamReader sr = new StreamReader(Console.ReadLine()))
                {
                    Console.WriteLine($"file is found...");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("something is wrong .. file not found");
            }
            catch (IOException e)
            {
                Console.WriteLine("somethings is wrong ..." + e.Message);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("something is weird..." + e.Message);
                throw;
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine("files acces denied " + e.Message);
            }


        }
        public static void Exo4()
        {
            /*
             * Write a C# program that prompts the user to input a numeric integer and throws an exception if the number is less than 0 or greater than 1000.
             */
            Console.WriteLine("input a numeric integer and throws an exception if the number is less than 0 or greater than 1000.");
            int firstNumber = 0;
            var done = false;

            try
            {
                firstNumber = Fonction.EnterNumber();
                LessThan(firstNumber, 0);
                HigherThan1000(firstNumber);
                Console.WriteLine($"the input {firstNumber} is correct");
                done = true;
            }
            catch (Less e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (High e)
            {
                Console.WriteLine($"{e.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("wrong input try with an integers");
            }
            catch (Exception)
            {
                Console.WriteLine("an unfortunate error is been detected");
                throw;
            }
            if (!done)
            {
                Exo4();
            }

        }
        class Less : Exception
        {
            public Less(string message) : base(message)
            {

            }
        }
        class High : Exception
        {
            public High(string message) : base(message)
            {
            }
        }
        private static void LessThan(int number, int amount)
        {
            if (number < amount)
            {
                throw new Less("input less than " + amount);
            }
        }
        private static void HigherThan1000(int number)
        {
            if (number > 1000)
            {
                throw new High("Input higher than 1000");
            }
        }
        public static void Exo5()
        {
            /*
             * Write a C# program that implements a method that takes an array of integers as input and calculates the average value. Handle the exception if the array is empty.
             */
            Console.WriteLine("Write a C# program that implements a method that takes an array of integers as input and calculates the average value. Handle the exception if the array is empty.");
            int numberOfGrades = 0;
            int sum = 0;
            Console.WriteLine(" ");
            Console.WriteLine("How many grades do you have ?");
            numberOfGrades = Fonction.EnterNumber();
            int[] average = new int[numberOfGrades];
            for (int i = 0; i < numberOfGrades; i++)
            {
                Console.WriteLine("your grade(s): ");
                average[i] = Fonction.EnterNumber();
                Console.WriteLine(" ");
            }
            foreach (int number in average)
            {
                Console.WriteLine(number);
                sum += number;
            }
            int calcAverage = sum / average.Length;
            Console.WriteLine($"the average of those grades is {calcAverage}");

        }
        public static void Exo6()
        {
            /*
             * 
             */
            Console.WriteLine("this exercice does`nt exist yet");

        }
        public static void Exo7()
        {
            /*
             * 
             */
            Console.WriteLine("this exercice does`nt exist yet");

        }
        public static void Exo8()
        {
            /*
             * 
             */
            Console.WriteLine("this exercice does`nt exist yet");

        }
        public static void Exo9()
        {
            /*
            *
            */
            Console.WriteLine("this exercice does`nt exist yet");

        }
        public static void Exo10()
        {
            /*
             * 
             */
            Console.WriteLine("this exercice does`nt exist yet");

        }


    }

}

