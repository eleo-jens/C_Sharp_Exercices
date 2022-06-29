using System;

namespace Revision_Loop_Ex_2
{
    //Réalisez un algorithme qui demande un nombre à l'utilisateur et affiche autant de ligne que le nombre spécifié par l'utilisateur.Exemple : l'utilisateur a rentré le nombre 5 et l'algorithme affiche : ***************
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Entrez un nombre entier: ";
            string input;
            int nb;

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre entier correct";
            } while (!int.TryParse(input, out nb) || nb < 0);

            string etoile = "";
            for (int i = 0; i <= nb; i++)
            {
                etoile = etoile + "*";
                Console.WriteLine(etoile);
            }
        }
    }
}
