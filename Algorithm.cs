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
        public static void Exo8()
        {
            Console.WriteLine("Write a C# Sharp program to create a string which is 4 copies of the 2 front characters of a given string. If the given string length is less than 2 return the original string. ");
            var str = Fonction.EnterString();

            string firstLetter;
            if (str.Length != 1)
            {
                firstLetter = (str.Substring(0, 2));
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(firstLetter);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(str);
            }
        }
        public static void Exo9()
        {
            Console.WriteLine("Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.");
            char lastLetter;
            var str = Fonction.EnterString();
            lastLetter = str[str.Length - 1];
            Console.WriteLine(lastLetter + str + lastLetter);
        }
        public static void Exo10()
        {
            Console.WriteLine("Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.");
            int number = Fonction.EnterNumber();
            int ismultipleto3 = number % 3;
            int ismultipleto7 = number % 7;
            if (ismultipleto3 == 0 || ismultipleto7 == 0)
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
        public static void Exo11()
        {
            Console.WriteLine("Write a C# Sharp program to create a string taking the first 3 characters of a given string. Return the string with the 3 characters added at both the front and back. If the given string length is less than 3, use whatever characters are there.");
            string firstLetter;
            var str = Fonction.EnterString();
            firstLetter = str.Substring(0, 3);
            Console.WriteLine(firstLetter + str + firstLetter);
        }
        public static void Exo12()
        {
            Console.WriteLine("Write a C# Sharp program to check if a given string starts with 'C#' or not. ");
            string firstLetter;
            var str = Fonction.EnterString();
            firstLetter = str.Substring(0, 2);
            if (firstLetter == "C#")
            {
                Console.WriteLine("TRUE");
            }
            else
            {
                Console.WriteLine("FALSE");
            }
        }
        public static void Exo13()
        {
            Console.WriteLine("return how many double letters combinaison we can find on a string");
            string wordDefault = "ghdlqvldghldqvdlaaadaaaaokleolghplokgh";

            Dictionary<string, int> dico = new Dictionary<string, int>();
            for (int i = 0; i < wordDefault.Length - 1; i++)
            {
                var combinaison = wordDefault[i].ToString() + wordDefault[i + 1].ToString();
                if (dico.TryGetValue(combinaison, out int count))
                {
                    dico[combinaison] = count + 1;
                }
                else
                {
                    dico.Add(combinaison, 1);
                }
            }

            foreach (var keyValuePair in dico.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{keyValuePair.Key} : {keyValuePair.Value} fois");
            }

        }
    }
}

