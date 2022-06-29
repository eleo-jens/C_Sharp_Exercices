using System;

namespace Revision_Loop_Ex_3
{
    //Ecrivez un algorithme qui demande à l’utilisateur de taper 10 entiers et qui affiche le plus petit de ces entiers.
    class Program
    {
        static void Main(string[] args)
        {
            int time = 10;
            string message;
            string input;
            int nombre;
            int temp = Int32.MaxValue;

            while (time > 0)
            {
                message = "Entrez un entier: ";
                do
                {
                    Console.WriteLine(message);
                    input = Console.ReadLine();
                    message = "Entrez un nombre entier correct (positif!)...";
                    Console.Clear();

                } while (!int.TryParse(input, out nombre) || nombre < 0);

                if (nombre < temp)
                {
                    temp = nombre; 
                }
                time--;
            }
            Console.WriteLine($"Le plus petit nombre est: {temp}");
        }
    }
}
