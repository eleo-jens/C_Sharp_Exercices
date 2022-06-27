using System;
using System.Collections.Generic;

namespace Tableau_Ex_5_corr
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todolist = new List<string>();
            string userChoice;
            do
            {
                // Afficher la liste
                int count = 1;
                foreach (string item in todolist)
                {
                    Console.WriteLine($"{count}) {item}");
                    count++;
                }

                // Menu d'utilisation
                do
                {
                    Console.WriteLine("Pour ajouter une tâche appuyer sur 'A'.");
                    if (todolist.Count > 0)
                    {
                        Console.WriteLine("Pour supprimer une tâche appuyer sur 'S'.");
                    }
                    Console.WriteLine("Pour quitter appuyez sur 'Q'");
                    userChoice = Console.ReadLine();
                } while (userChoice != "A" && userChoice != "Q" && (userChoice != "S" || todolist.Count <= 0));

                switch (userChoice)
                {
                    // Ajouter
                    case "A":
                        Console.WriteLine("Veuillez indiquer la tâche à accomplir: ");
                        string task = Console.ReadLine();

                        // On verifie si la liste contient déjà la tache, si non on l'ajoute
                        if (!todolist.Contains(task))
                        {
                            todolist.Add(task);
                        }
                        break;
                    // Supprimer
                    case "S":
                        // on utilise l'index numérique pour supprimer l'élement
                        int index_to_remove;
                        do
                        {
                            Console.WriteLine("Veuillez identifier une tâche à supprimer: ");
                        } while (!int.TryParse(Console.ReadLine(), out index_to_remove) || index_to_remove < 1 || index_to_remove > todolist.Count);
                        // -1 car notre liste commence à 1 visuellement
                        todolist.Remove(todolist[index_to_remove-1]);
                        break;
                    case "Q":
                        Console.WriteLine("Au revoir, merci d'avoir utilisé To-Do-List-3000!");
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (userChoice != "Q");
        }
    }
}
