using System;
using System.Collections.Generic;

namespace Tableaux_Ex_1
{
    //Grâce à une boucle «while» et à l’aide d’une collection, 
    //calculez les nombres premiers inférieur à un nombre entier entré au clavier.
    class Program
    {
        static void Main(string[] args)
        {
            int limit;
            do
            {
                Console.WriteLine("veuillez indiquer le nombre premier à récupérer");
            } while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0);

            //ensemble de mes nombres premiers
            List<int> primes = new List<int>();

            //comptabiliser le nombre de nb premier que je veux atteindre (c'est la limit)
            //récupération des valeurs tant que le nombre de primes dans mon tableau est inférieur à ma limite
            // nb_test est le nombre que je suis en train de tester
            for (int nb_test = 0; primes.Count < limit; nb_test++)
            {
                int nbDiv = 0;
                // autre boucle pour augmenter les diviseurs pour pouvoir les tester; dès qu'on trouve un 3e diviseur on ne doit plus rentrer dedans
                for (int diviseur = 1; diviseur <= nb_test && nbDiv <= 2; diviseur++)
                {
                    // si le modulo est = 0 alors on a trouvé un diviseur
                    if (nb_test % diviseur == 0) nbDiv++;
                }
                // vérifier si le nombre de diviseur à 2 dans ce cas c'est un nb primes
                if (nbDiv == 2) primes.Add(nb_test);
            }

            foreach(int prime in primes)
            {
                Console.WriteLine($"{prime} est un nombre premier");
            }


            #region autre version optimisé avec racine carrée
            //int limit;
            //do
            //{
            //    Console.WriteLine("veuillez indiquer le nombre premier à récupérer");
            //} while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0);

            ////ensemble de mes nombres premiers
            //List<int> primes = new List<int>();

            ////comptabiliser le nombre de nb premier que je veux atteindre (c'est la limit)
            ////récupération des valeurs tant que le nombre de primes dans mon tableau est inférieur à ma limite
            //// nb_test est le nombre que je suis en train de tester
            //for (int nb_test = 2; primes.Count < limit; nb_test++)
            //{
            //    bool nbIsPrime = true;
            //    // autre boucle pour augmenter les diviseurs pour pouvoir les tester; dès qu'on trouve un 3e diviseur on ne doit plus rentrer dedans
            //    for (int diviseur = 1; diviseur <= Math.Sqrt(nb_test) && nbIsPrime; diviseur++)
            //    {
            //        // si le modulo est = 0 alors on a trouvé un diviseur
            //        if (nb_test % diviseur == 0) nbIsPrime = false;
            //    }
            //    // vérifier si le nombre de diviseur à 2 dans ce cas c'est un nb primes
            //    if (nbIsPrime) primes.Add(nb_test);
            //}

            //foreach (int prime in primes)
            //{
            //    Console.WriteLine($"{prime} est un nombre premier");
            //}
            #endregion

            #region autre version optimisée en divisant par les nombres premiers
            //int limit;
            //do
            //{
            //    Console.WriteLine("veuillez indiquer le nombre premier à récupérer");
            //} while (!int.TryParse(Console.ReadLine(), out limit) || limit <= 0);

            ////ensemble de mes nombres premiers
            //List<int> primes = new List<int>();

            ////comptabiliser le nombre de nb premier que je veux atteindre (c'est la limit)
            ////récupération des valeurs tant que le nombre de primes dans mon tableau est inférieur à ma limite
            //// nb_test est le nombre que je suis en train de tester
            //for (int nb_test = 2; primes.Count < limit; nb_test++)
            //{
            //    bool nbIsPrime = true;
            //    // autre boucle pour augmenter les diviseurs pour pouvoir les tester;
            //    // on vérifie s'ils sont divisibles par les nb premier
            //    for (int index = 0; primes.Count > 0 && primes[index] <= Math.Sqrt(nb_test) && nbIsPrime; index++)
            //    {
            //        // si le modulo est = 0 alors on a trouvé un diviseur
            //        if (nb_test % primes[index] == 0) nbIsPrime = false;
            //    }
            //    // vérifier si le nombre de diviseur à 2 dans ce cas c'est un nb primes
            //    if (nbIsPrime) primes.Add(nb_test);
            //}

            //foreach (int prime in primes)
            //{
            //    Console.WriteLine($"{prime} est un nombre premier");
            //}
            #endregion
        }
    }
}
