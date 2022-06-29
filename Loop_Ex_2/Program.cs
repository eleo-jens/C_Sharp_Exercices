using System;

namespace Loop_Ex_2
{
    //Calculer la factorielle d'un nombre entre au clavier
    // corriger integrer un long et verifier si le nombre est inferieur a 0 et superieur au nombre dont la factorielle depassera le long
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int nb;
            string message = "Veuillez entrer un nombre: ";
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Entrez un nombre correct...";
            } while (!int.TryParse(input, out nb));

            int n = 1;
            for (int i = nb; i > 0; i--)
            {
                n = n * i;
            }
            Console.WriteLine($"La factorielle de {nb} est {n}");
        }
    }
}
