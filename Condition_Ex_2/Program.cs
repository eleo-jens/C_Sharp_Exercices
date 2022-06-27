using System;

namespace Condition_Ex_2
{
    class Program
    {
        static Random RNG = new Random(); //variable membre qui appartient à l'ensemble du programme grace à "static": c'est un constructeur: fonction de construction qui permet de créer la fonction Random: j'instancie un élement de type random
        static void Main(string[] args)
        {
            Console.WriteLine("Jeu du Pierre Papier Ciseaux: veuillez choisir:\n (1) Pierre\n (2) Papier\n (3) Ciseaux");
            int user_number;
            string input = Console.ReadLine();
            if (int.TryParse(input, out user_number) && user_number >=1 && user_number <= 3)
            {
                int aleatoire_pc = RNG.Next(1, 4); 
                string message = "";
                switch (user_number)
                {
                    case 1:
                        message = "Vous: Pierre - ";
                        break;
                    case 2:
                        message = "Vous: Papier - ";
                        break;
                    case 3:
                        message = "Vous: Ciseaux - ";
                        break;
                }
                switch (aleatoire_pc)
                {
                    case 1:
                        message = message + "Ordi: Pierre";
                        break;
                    case 2:
                        message = message + "Ordi: Papier";
                        break;
                    case 3:
                        message = message + "Ordi: Ciseaux";
                        break;
                }
                Console.WriteLine(message);

                if (user_number == aleatoire_pc) Console.WriteLine("Match Nul!");
                else if ((user_number == 1 & aleatoire_pc == 3) || (user_number == 2 && aleatoire_pc == 1) || (user_number == 3 && aleatoire_pc == 2))
                {
                    Console.WriteLine("Vous avez gagné !");
                }
                else Console.WriteLine("L'ordinateur a gagné !");
            }
            else Console.WriteLine("Vous avez rentré une valeur incorrecte...");
            //Console.WriteLine("Merci d'avoir joué ;)");

            //Console.WriteLine(2 % 4);
            //Console.WriteLine(3 % 4);
            //Console.WriteLine(4 % 4);
        }
    }
}
