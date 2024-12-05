using Microsoft.VisualBasic;

namespace Exercice
{
    public class ExerciceBasicAlgorithm1_30
    {
        public static void Exo1()
        {
            /*
             * Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.
             */
            Console.WriteLine("compute the sum of the two numerical values. If the two values are the same, return triple their sum.");
            int x = 0;
            int y = 0;
            int result = 0;
            int triple = 0;
            y = Fonction.EnterNumber();
            x = Fonction.EnterNumber();
            result = y + x;
            Console.WriteLine($"the result is {result}");
            triple = result * 3;
            if (x == y)
            {
                Console.WriteLine($"inputs is the same, the result is {triple}");
            }

        }
        public static void Exo2()
        {
            /*
             * Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.
             */
            Console.WriteLine("get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.");
            int firstNumber = 0;
            int Number = 51;
            int result = 0;


            Console.WriteLine("first number ? ");
            firstNumber = Fonction.EnterNumber();

            result = Math.Abs(Number - firstNumber);

            if (firstNumber <= Number)
            {
                Console.WriteLine($"the result of {Number} - {firstNumber} is: {result}");
            }
            else
            {
                Console.WriteLine("the input is higher than 51... ");
                int resultTriple = result * 3;
                Console.WriteLine($"the result of the result is: {resultTriple}");
            }

        }
        public static void Exo3()
        {
            /*
             Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.
             */
            Console.WriteLine("check two given integers, and return true if one of them is 30 or if their sum is 30.");
            int firstNumber = 0;
            int secondNumber = 0;
            int sum = 0;

            Console.WriteLine("first number ? ");
            firstNumber = Fonction.EnterNumber();
            Console.WriteLine("second number ? ");
            secondNumber = Fonction.EnterNumber();
            sum = firstNumber + secondNumber;

            //var result = sum == 30 || firstNumber == 30 || secondNumber == 30;
            //Console.WriteLine(result);


            if (sum == 30 || firstNumber == 30 || secondNumber == 30)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

        }
        public static void Exo4()
        {
            /*
             * Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200. 
             */

            //

            List<int> numbers = new List<int>() { 100, 200 };


            Console.WriteLine("check a given integer and return true if it is within 10 of 100 or 200.");
            int mininterval = 90;
            int mininterval1 = 190;
            int maxinterval = 110;
            int maxinterval1 = 210;
            int firstNumber = 0;

            Console.WriteLine("first number ? ");
            firstNumber = Fonction.EnterNumber();

            if (firstNumber >= mininterval && firstNumber <= maxinterval)
            {
                Console.WriteLine(true + $" {firstNumber} is within 10 of 100 ");
            }
            else
            {
                Console.WriteLine(false + $" {firstNumber} isn't within 10 of 100");
            }
            if (firstNumber >= mininterval1 && firstNumber <= maxinterval1)
            {
                Console.WriteLine(true + $" {firstNumber} is within 10 of 200 ");
            }
            else
            {
                Console.WriteLine(false + $" {firstNumber}isn't within 10 of 200 ");
            }
        }
        public static void Exo5()
        {
            /* Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged. 
             */
            Console.WriteLine("Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged. ");
            string input = " ";
            input = Fonction.EnterString();
            if (input.Length > 2 && input.Substring(0, 2).ToUpper().StartsWith("IF"))
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine($"if {input}");
            }

        }
        public static void Exo6()
        {
            /* Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive. 
             */
            Console.WriteLine("Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive. ");
            string input = Fonction.EnterString();
            int index = Fonction.EnterNumber();
            if (input.Length > index && index >= -1)
            {
                string inputRemovedIndex = input.Remove(index, 1);
                Console.WriteLine(inputRemovedIndex);
            }
            else
            {
                Console.WriteLine("Please take an input correct");
            }

        }
        public static void Exo7()
        {
            /*  Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. */
            Console.WriteLine("Write a C# Sharp program to exchange the first and last characters in a given string and return the new string. ");
            var str = Fonction.EnterString();
            string theRestOfTheWord;
            string lastLetter;
            string firstLetter;
            if (str.Length != 1)
            {
                firstLetter = (str.Substring(0, 1));
                lastLetter = (str.Substring(str.Length - 1));
                theRestOfTheWord = (str.Substring(1, str.Length - 2));
                Console.WriteLine($"{lastLetter}{theRestOfTheWord}{firstLetter}");

            }
            else
            {
                Console.WriteLine(str);
            }
        }
    }
}
