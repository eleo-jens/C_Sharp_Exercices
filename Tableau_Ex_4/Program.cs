using System;
using System.Collections.Generic;

namespace Tableau_Ex_4
{

    // Une application permettant d'enregistrer des tâches dans une liste
    // Afficher la liste entière à l'écran et donner la possibilité d'ajouter ou de supprimer des tâches
    class Program
    {
        static void Main(string[] args)
        {
            //creation d'un tableau de taille variable accueillant uniquement des strings de caractère
            List<string> to_do_list = new List<string>();
            int i;
            Console.WriteLine("---TO DO LIST---");

            do
            {
                //Interface utilisateur via message
                Console.WriteLine("Souhaitez vous:\n1) Ajouter une nouvelle tâche à la liste (tapez 1)\n2) Supprimer une tâche (tapez 2)\n3) Quitter l'application (taper 3)");
                string input = Console.ReadLine();
                int.TryParse(input, out i);

                //Ajout d'une tache
                if (i == 1)
                {
                    Console.WriteLine("\nUne nouvelle tâche: ");
                    to_do_list.Add(Console.ReadLine());
                    Console.Clear();
                }

                //Suppresion d'une tâche
                else if (i == 2)
                {
                    Console.WriteLine("Entrez le numéro de la tâche que vous souhaitez supprimer:");
                    input = Console.ReadLine();
                    int index;
                    if (int.TryParse(input, out index))
                    {
                        to_do_list.Remove(to_do_list[index]);
                    }
                    Console.Clear();
                }
                //Affichage des taches mises à jour
                if (to_do_list.Count >= 1)
                {
                    int index = 0;
                    foreach (string task in to_do_list)
                    {
                        Console.WriteLine($"{index}: {task}");
                        index++;
                    }
                }
            } while (i != 3);
        }
    }
}
