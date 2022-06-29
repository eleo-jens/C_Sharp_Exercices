using System;

namespace Revision_Loop_Ex_1
{

    //Réalisez un système de connexion à l'aide d'un mot de passe.L'algorithme demande à l'utilisateur de saisir son mot de passe.Si ce dernier valide de bon mot de passe, on le salue.Par contre, si il fait une erreur trois fois de suite, un message lui signalera que son compte est bloqué et il ne pourra pasréessayer une quatrième fois
    class Program
    {
        static void Main(string[] args)
        {
            string password = "HelloWorld!";
            int attempt = 3;
            Console.WriteLine("Entrez votre mot de passe: ");
            string input = Console.ReadLine();

            while (input != password && attempt > 1)
            {
                Console.WriteLine("Mot de passe incorret. Réssayez: ");
                input = Console.ReadLine();
                attempt--;
            }
            if (input == password)
            {
                Console.WriteLine("Bienvenue!");
            }
            else
            {
                Console.WriteLine("Vous avez dépasser le nombre d'essaies possibles. Votre compte est bloqué.");
            }
        }
    }
}
