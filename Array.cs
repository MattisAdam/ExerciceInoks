using System.Threading.Tasks.Sources;
using System.Xml.Linq;

namespace Exercice
{
    public class Array
    {
        public static void Exo1()
        {
            //Write a C# Sharp program to count the frequency of each element in an array. 
            int element;
            int nmbRandom = 20;
            int[] check = new int[nmbRandom];
            Random rnd = new Random();
            string correction = string.Empty;

            //dico avec nmb de fois la lettre, 1 si 0 et +1 si deja 1


            int x = Fonction.EnterNumber("Input the number of elements to be stored in the array");
            Console.WriteLine("");
            int[] tab = new int[x];
            Console.WriteLine("Do u want to see the correction ? y/n");
            correction = Fonction.EnterString("Enter y/n");
            correction = correction.ToUpper();
            // init
            for (int i = 0; i < tab.Length; i++)
            {
                element = rnd.Next(nmbRandom);
                if (correction == "Y")
                {
                    Console.WriteLine(element);
                }
                else
                {
                    while ((correction != "Y") && (correction != "N"))
                    {
                        Console.WriteLine("Wrong input");
                        Console.WriteLine("Do u want to see the correction ? y/n");
                        correction = Fonction.EnterString("Enter y/n");
                        correction = correction.ToUpper();

                    }
                }

                tab[i] = element;
            }

            //algo
            for (int i = 0; i < check.Length; i++)
            {
                check[i] = 0;

                //Console.WriteLine(check[i]);
            }
            for (int i = 0; i < tab.Length; i++)
            {
                check[tab[i]] += 1;
            }
            for (int i = 0; i < check.Length; i++)
            {
                Console.WriteLine($"{i} est representé {check[i]} de fois");
            }





        }
        public static void Exo2()
        {
            /*Write a C# Sharp program to delete an element at the desired position from an array.*/
            int numberIntInArray = Fonction.EnterNumber("How many integers contains in the array ?");
            Console.WriteLine("");
            int[] tab = new int[numberIntInArray];
            bool check = false;
            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 1;
                //Console.WriteLine(tab[i]);
            }
            while (check == false)
            {
                Console.WriteLine("");
                int PositionIntInArrayToRemove = Fonction.EnterNumber("At wich position would you remove an integers ? ");
                Console.WriteLine("");

                if (PositionIntInArrayToRemove < tab.Length)
                {
                    for (int i = 0; i < tab.Length; i++)
                    {
                        if (tab[i] != tab[PositionIntInArrayToRemove])
                        {
                            Console.WriteLine(tab[i]);
                        }
                    }
                    check = true;
                }
                else
                {
                    Console.WriteLine($"Enter a less postion than [{numberIntInArray - 1}]");
                }
            }

        }
    }
}

