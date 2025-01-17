namespace Exercice
{
    public class Fonction
    {
        public static void MenuMain()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------EXERCICE----------");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            Console.WriteLine("Welcome !");
            while (true)
            {
                int x = 0;
                int y = 0;
                int numberExercice = 4;
                Console.WriteLine("wich one you would see ?");
                Console.WriteLine(".1 ExerciceBasic1_30");
                Console.WriteLine(".2 ExerciceBasicalgorithm1_30");
                Console.WriteLine(".3 ExerciceException1_13");
                Console.WriteLine(".4 ExerciceArray");
                Console.WriteLine(" ");
                x = Fonction.EnterNumber("Wich Exerice ?");
                if (x <= 0 || x > numberExercice)
                {
                    Console.WriteLine($" (!ERROR!) take a choice between 1 and {numberExercice} ");
                }
                else
                {
                    Console.WriteLine("Enter the number of the exerice you want");
                    y = Fonction.EnterNumber();
                }
                if (x == 1)
                //Basics Exercices
                {
                    switch (y)
                    {
                        case 1:
                            ExcerciceBasic1_30.Exo1();
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            ExcerciceBasic1_30.Exo2();
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            ExcerciceBasic1_30.Exo3(); // A REVOIR
                            Console.WriteLine(" ");
                            break;
                        case 4:
                            ExcerciceBasic1_30.Exo4();
                            Console.WriteLine(" ");
                            break;
                        case 5:
                            ExcerciceBasic1_30.Exo5();
                            Console.WriteLine(" ");
                            break;
                        case 6:
                            ExcerciceBasic1_30.Exo6();
                            Console.WriteLine(" ");
                            break;
                        case 7:
                            ExcerciceBasic1_30.Exo7();
                            Console.WriteLine(" ");
                            break;
                        case 8:
                            ExcerciceBasic1_30.Exo8();
                            Console.WriteLine(" ");
                            break;
                        case 9:
                            ExcerciceBasic1_30.Exo9(); // A REVOIR
                            Console.WriteLine(" ");
                            break;
                        case 10:
                            ExcerciceBasic1_30.Exo10();
                            Console.WriteLine(" ");
                            break;
                        case 11:
                            ExcerciceBasic1_30.Exo11();
                            Console.WriteLine(" ");
                            break;

                        case 12:
                            ExcerciceBasic1_30.Exo12();
                            Console.WriteLine(" ");
                            break;
                        case 13:
                            ExcerciceBasic1_30.Exo13();
                            Console.WriteLine(" ");
                            break;
                        case 14:
                            ExcerciceBasic1_30.Exo14();
                            Console.WriteLine(" ");
                            break;

                    }
                }

                if (x == 2)
                //algo Exercices
                {
                    switch (y)
                    {
                        case 1:
                            ExerciceBasicAlgorithm1_30.Exo1();
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            ExerciceBasicAlgorithm1_30.Exo2();
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            ExerciceBasicAlgorithm1_30.Exo3();
                            Console.WriteLine(" ");
                            break;
                        case 4:
                            ExerciceBasicAlgorithm1_30.Exo4();
                            Console.WriteLine(" ");
                            break;
                        case 5:
                            ExerciceBasicAlgorithm1_30.Exo5();
                            Console.WriteLine(" ");
                            break;
                        case 6:
                            ExerciceBasicAlgorithm1_30.Exo6();
                            Console.WriteLine(" ");
                            break;
                        case 7:
                            ExerciceBasicAlgorithm1_30.Exo7();
                            break;
                        case 8:
                            ExerciceBasicAlgorithm1_30.Exo8();
                            break;
                        case 9:
                            ExerciceBasicAlgorithm1_30.Exo9();
                            break;
                        case 10:
                            ExerciceBasicAlgorithm1_30.Exo10();
                            break;
                        case 11:
                            ExerciceBasicAlgorithm1_30.Exo11();
                            break;

                        case 12:
                            ExerciceBasicAlgorithm1_30.Exo12();
                            break;



                    }
                }
                if (x == 3)
                {
                    switch (y)
                    {
                        case 1:
                            ExcerciceException1_13.Exo1();
                            Console.WriteLine(" ");
                            break;
                        case 2:
                            ExcerciceException1_13.Exo2();
                            Console.WriteLine(" ");
                            break;
                        case 3:
                            ExcerciceException1_13.Exo3();
                            Console.WriteLine(" ");
                            break;
                        case 4:
                            ExcerciceException1_13.Exo4();
                            Console.WriteLine(" ");
                            break;
                        case 5:
                            ExcerciceException1_13.Exo5();
                            Console.WriteLine(" ");
                            break;
                        case 6:
                            ExcerciceException1_13.Exo6();
                            Console.WriteLine(" ");
                            break;
                        case 7:
                            ExcerciceException1_13.Exo6();
                            Console.WriteLine(" ");
                            break;
                        case 8:
                            ExcerciceException1_13.Exo8();
                            Console.WriteLine(" ");
                            break;
                        case 9:
                            ExcerciceException1_13.Exo9();
                            Console.WriteLine(" ");
                            break;
                        case 10:
                            ExcerciceException1_13.Exo10();
                            Console.WriteLine(" ");
                            break;
                    }

                }
                if (x == 4)
                {
                    switch (y)
                    {
                        case 1: Array.Exo1(); Console.WriteLine(" "); break;
                        case 2: Array.Exo2(); Console.WriteLine(""); break;
                    }
                    break;
                }
                if (x == 5)
                {
                    ExerciceBasicAlgorithm1_30.Exo13();
                }

            }
        }
        public static double EnterPct(string question = "Enter a number...", string messageError = "It's not a number, try again !")
        {
            double number = 0;
            number = EnterNumber(question, messageError);
            return number / 100d;
        }
        public static int EnterNumber(string question = "Enter a number...", string messageError = "It's not a number, try again !")
        {
            while (true)
            { 
                Console.WriteLine();
                Console.Write($"{question}   ");
                string input = Console.ReadLine();
                //another method in private 
                if (int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.WriteLine(messageError);
                }
            }
        }

        public static string EnterString(string question = "Enter a string...", string messageError = "It's not a string, try again !")
        {
            Console.WriteLine(question);
            var x = Console.ReadLine();

            return x;
        }
    }
}
