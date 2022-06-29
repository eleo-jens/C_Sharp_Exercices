using System;

namespace Revision_Loop_Ex_4
{
    //Algorithme demandant 3 nombres : nbRep, nbTiret, nbEspace.Ce dernier affiche à l'écran autant de tiret que la valeur de nbTiret, suivi d'autant d'espace que la valeur de nbEspace. Le tout autant de fois que la valeur de nbRep.Exemple : si nbRep= 2, nbTiret= 1 et nbEspace= 3 le résultat est le suivant :|--|
    class Program
    {
        static void Main(string[] args)
        {
            int nbRep;
            int nbTiret;
            int nbEspace;
            string input;
            string message = "Insérer un nombre entier de répétition: ";

            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre entier correct..."; 
                Console.Clear();

            } while (!int.TryParse(input, out nbRep) || nbRep < 0);
            message = "Insérer un nombre entier de tiret: ";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre entier correct...";
                Console.Clear();

            } while (!int.TryParse(input, out nbTiret) || nbTiret < 0);
            message = "Insérer un nombre entier d'espace: ";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre entier correct...";
                Console.Clear();

            } while (!int.TryParse(input, out nbEspace) || nbEspace < 0);

            string str = "|";
            while (nbRep > 0)
            {
                int nbTiretcopy = nbTiret;
                int nbEspacecopy = nbEspace;
                while (nbTiretcopy > 0)
                {
                    str += "-";
                    nbTiretcopy--;
                }
                while (nbEspacecopy > 0)
                {
                    str += " ";
                    nbEspacecopy--;
                }
                nbRep--;
            }
            Console.WriteLine(str + "|");
        }
    }
}
