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

            //dico avec nmb de fois la lettre, 1 si 0 et +1 si deja 1


            int x = Fonction.EnterNumber("Input the number of elements to be stored in the array");
            Console.WriteLine("");
            int[] tab = new int[x];


            // init
            for (int i = 0; i < tab.Length; i++)
            {
                element = rnd.Next(nmbRandom);
                Console.WriteLine(element);
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

            for (int y = 0; y < check.Length; y++)
            {
                Console.WriteLine($"{y} est representé {check[y]} de fois");
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
                Console.WriteLine(tab[i]);
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

