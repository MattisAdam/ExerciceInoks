using System.ComponentModel;

namespace Exercice
{
    public class ExcerciceBasic1_30
    {

        public static void Exo1()
        {
            //exercice 1
            /**
             Write a C# Sharp program to print Hello and your name in a separate line
             * */
            Console.WriteLine("Hello " + Fonction.EnterString());
        }
        public static void Exo2()
        {
            //exercice 2
            /** 
             Write a C# Sharp program to print the sum of two numbers.
            */
            int x = 0;
            int y = 0;
            int sum = 0;
            Console.WriteLine("first number : ");
            x = Fonction.EnterNumber();
            Console.WriteLine("second numbers : ");
            y = Fonction.EnterNumber();
            sum = x + y;
            Console.WriteLine($"the sum is {sum}");
        }


        // A REVOIR
        public static void Exo3()
        {
            // exercice 3
            /**
             Write a C# Sharp program to print the result of dividing two numbers.

             */
            int x = Fonction.EnterNumber("Enter numerator of division :");
            int y = 0;
            while (y == 0)
            {
                y = Fonction.EnterNumber("Enter denominator of division :");
                if (y == 0)
                    Console.WriteLine("Divide by zero impossible");
            }

            var result = (double)x / (double)y;
            Console.WriteLine($"the result is {result:N2}");
        }
        public static void Exo4()

        {
            //exercice 4
            /**
            * Write a C# Sharp program to print the results of the specified operations.
            */
            Console.WriteLine("print the results of the specified operations.");
            Console.WriteLine(" ");


            int output1 = -1 + 4 * 6;
            Console.WriteLine("output1 =-1 + 4 * 6 == " + output1);
            Console.WriteLine(" ");
            int output2 = (35 + 5) % 7;
            Console.WriteLine("output2 = (35 + 5) % 7 == " + output2);
            Console.WriteLine(" ");
            int output3 = 14 + -4 * 6 / 11;
            Console.WriteLine("output3 = 14 + -4 * 6 / 11 == " + output3);
            Console.WriteLine(" ");
            int output4 = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("output4 = 2 + 15 / 6 * 1 - 7 % 2 == " + output4);
            Console.WriteLine(" ");
        }
        public static void Exo5()
        {
            //exercice 5
            /**
             *Write a C# Sharp program to swap two numbers.
             **/
            int firstNumbers = 0;
            int secondNumbers = 0;
            int swap;
            Console.WriteLine("swap two numbers.");
            Console.WriteLine("first number ? ");
            firstNumbers = Fonction.EnterNumber();
            Console.WriteLine("second number ? ");
            secondNumbers = Fonction.EnterNumber();
            swap = firstNumbers;
            firstNumbers = secondNumbers;
            secondNumbers = swap;
            Console.WriteLine($"First number is : {firstNumbers} ");
            Console.WriteLine($"Second number is : {secondNumbers} ");
        }
        public static void Exo6()
        {
            //exercice 6 
            /**
             *Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.
             */
            int firstNumbers = 0;
            int secondNumbers = 0;
            int thirdNumbers = 0;
            Console.WriteLine("print the output of the multiplication of three numbers.");
            Console.WriteLine("first number ? ");
            firstNumbers = Fonction.EnterNumber();
            Console.WriteLine("second number ? ");
            secondNumbers = Fonction.EnterNumber();
            Console.WriteLine("third number ? ");
            thirdNumbers = Fonction.EnterNumber();
            int calc = firstNumbers * secondNumbers * thirdNumbers;
            Console.WriteLine($"the result is {calc}");
        }
        public static void Exo7()
        {
            //exercice 7 
            /*
             Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.
             */
            int firstNumbers = 0;
            int secondNumbers = 0;
            Console.WriteLine("print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user");
            Console.WriteLine("first number ?");
            firstNumbers = Fonction.EnterNumber();
            Console.WriteLine("second number ? ");
            secondNumbers = Fonction.EnterNumber();
            int add = firstNumbers + secondNumbers;
            Console.WriteLine($"the result of the addition is {add}");
            int substracting = firstNumbers - secondNumbers;
            Console.WriteLine($"the result of the substration is {substracting}");
            int multi = firstNumbers * secondNumbers;
            Console.WriteLine($"the result of the multiplication is {multi}");
            int dividing = firstNumbers / secondNumbers;
            Console.WriteLine($"the result of the division is {dividing}");
            int modulo = firstNumbers % secondNumbers;
            Console.WriteLine($"the result of the modulo is {modulo}");

        }
        public static void Exo8()
        {
            //exercice 8
            /*
             * Write a C# Sharp program that prints the multiplication table of a number as input.
             */
            int firstNumbers = 0;
            Console.WriteLine("prints the multiplication table of a number as input");
            Console.WriteLine("first number ? ");
            firstNumbers = Fonction.EnterNumber();
            for (int i = 0; i <= 10; i++)
            {
                int result = firstNumbers * i;
                Console.WriteLine($"{firstNumbers} * {i} = {result}");
            }
        }
        // A REVOIR
        public static void Exo9()
        {
            //exercice 9
            /*
             * Write a C# Sharp program that takes n numbers as input to calculate and print the average
             * Ask First how many numbers
             * Then ask all numbers
             * Then display average
              */
            int firstNumbers = 0;
            int secondNumbers = 0;
            int thirdNumbers = 0;
            int fourNumbers = 0;
            Console.WriteLine("takes n numbers as input to calculate and print the average");
            List<int> average = new List<int>();

            Console.WriteLine("first number ? ");
            firstNumbers = Fonction.EnterNumber();
            average.Add(firstNumbers);
            Console.WriteLine("second number ? ");
            secondNumbers = Fonction.EnterNumber();
            average.Add(secondNumbers);
            Console.WriteLine("third number ? ");
            thirdNumbers = Fonction.EnterNumber();
            average.Add(thirdNumbers);
            Console.WriteLine("four number ? ");
            fourNumbers = Fonction.EnterNumber();
            average.Add(fourNumbers);
            int we = average.Count;
            int averageCalc = 0;
            int averageCalc1 = 0;
            for (int i = 0; i < we; i++)
            {
                if (i < we - 1)
                {
                    averageCalc = average[0] + average[2];
                    averageCalc1 = average[1] + average[3];
                }
            }
            int sum = averageCalc + averageCalc1;
            int Average = sum / average.Count;
            Console.WriteLine(Average);
        }
        public static void Exo10()
        {
            /*
             *  Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
             */
            Console.WriteLine("takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.");
            int firstCalc = 0;
            int secondCalc = 0;
            int result = 0;
            int firstNumbers = 0;
            int secondNumbers = 0;
            int thirdNumbers = 0;
            Console.WriteLine("first number ? ");
            firstNumbers = Fonction.EnterNumber();
            Console.WriteLine("second number ? ");
            secondNumbers = Fonction.EnterNumber();

            Console.Write("third number ? ");
            thirdNumbers = Fonction.EnterNumber();

            firstCalc = (firstNumbers + secondNumbers) * thirdNumbers;
            Console.WriteLine($"the first result is {firstCalc}");
            firstCalc = firstNumbers * secondNumbers;
            secondCalc = secondNumbers * thirdNumbers;
            result = firstCalc + secondCalc;
            Console.WriteLine($"the second result is {result}");

        }
        public static void Exo11()
        {
            /*
             * Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".
             */
            Console.WriteLine("takes an age (for example 20) as input and prints something like \"You look older than 20.");
            int limitAge = 25;
            int age = 0;
            Console.WriteLine("Enter your age ");
            age = Fonction.EnterNumber();

            Console.WriteLine("u look older than " + limitAge);


        }
        public static void Exo12()
        {
            /*
             * Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation
             * */
            Console.WriteLine("takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation");
            int loop = 4;
            int num = 0;
            Console.WriteLine("enter a number");
            num = Fonction.EnterNumber();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < loop; j++)
                {
                    Console.Write($"{num} ");
                }
                Console.Write("\n");
                for (int j = 0; j < loop; j++)
                {
                    Console.Write($"{num}");
                }
                Console.Write("\n");
            }
        }
        public static void Exo13()
        {
            /*
             * Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit. 
             */
            int num = 0;
            Console.WriteLine("takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit. ");
            Console.WriteLine("enter a number");
            num = Fonction.EnterNumber();
            Console.Write($"{num}{num}{num} ");
            Console.WriteLine("");
            for (int j = 0; j < 3; j++)
            {

                for (int k = 0; k < 2; k++)
                {
                    Console.Write($"{num} ");

                }
                Console.WriteLine("");
            }
            Console.Write($"{num}{num}{num} ");
            Console.WriteLine("");
        }
        public static void Exo14()
        {
            /*Write a C# program to find the largest and lowest values from three integer values. */
            Console.WriteLine("Write a C# program to find the largest and lowest values from three integer values. ");

            int firstNumber = Fonction.EnterNumber("enter the first number");
            int secondNumber = Fonction.EnterNumber("enter the second number");
            int thirdNumber = Fonction.EnterNumber("enter the third number");

            if (firstNumber > secondNumber & firstNumber > thirdNumber)
            {
                Console.WriteLine($"the largest number of three is {firstNumber}");
            }
            else
            {
                if (firstNumber < secondNumber & firstNumber < thirdNumber)
                {
                    Console.WriteLine($"the lowest number of three is {firstNumber}");
                }
            }
            if (secondNumber > firstNumber & secondNumber > thirdNumber)
            {
                Console.WriteLine($"the largest number of three is {secondNumber}");
            }
            else
            {
                if (secondNumber < firstNumber & secondNumber < thirdNumber)
                {
                    Console.WriteLine($"the lowest number of three is {secondNumber}");
                }
            }
            if (thirdNumber > firstNumber & thirdNumber > secondNumber)
            {
                Console.WriteLine($"the largest number of three is {thirdNumber}");
            }
            else
            {
                if (thirdNumber < firstNumber & thirdNumber < secondNumber)
                {
                    Console.WriteLine($"the lowest number of three is {thirdNumber}");
                }
            }

            if(firstNumber == secondNumber & secondNumber == thirdNumber)
            {
                Console.WriteLine("we cannot find the largest number of three please retry");
                Console.WriteLine();
                Exo14();    
            }

            }
    }
}