using System;
using System.Collections.Generic; 

namespace Enum_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int TAILLE = 52;
            List<Card> card_game = new List<Card>();
            string[] ColorNames = Enum.GetNames<Colors>();
            string[] ValuesNames = Enum.GetNames<Values>();

            // on ne peut pas modifier une collection dans une foreach; on travaille en lecture seule donc on a juste lire les valeurs de énumérations et les donner comme valeur dans notre liste deck qui existe déjà en dehors de notre foreach
            foreach (string colorName in ColorNames)
            {
                Card card;
                card.color = Enum.Parse<Colors>(colorName);
                foreach (string valueName in ValuesNames)
                {
                    card.value = Enum.Parse<Values>(valueName);
                    card_game.Add(card); 
                    //card_game[i].color = carte.color;
                    //card_game[i].value = carte.value;
                }
            }

            // peut etre créer une méthode pour afficher des cartes ? 
            foreach(Card card in card_game)
            {
                Console.WriteLine($"{card.value} {card.color}");
            }

            // créer une structure pour la bataille: nb de participants;
            // dans cette structure créer une méthode pour distribuer les cartes
            // création de deux deck de 26 cartes
            Stack<Card> deck1 = new Stack<Card>();
            Stack<Card> deck2 = new Stack<Card>();
            while (card_game.Count != 0)
            {
                Random rand = new Random();
                int index_random = rand.Next(0, card_game.Count - 1);


                deck1.Push(card_game[index_random]);
                card_game.RemoveAt(index_random);
                deck2.Push(card_game[index_random]);
                card_game.RemoveAt(index_random);
            }


            // Affichage des deux tas
            Console.WriteLine("\nFirst deck:");
            foreach (Card card in deck1)
            {
                Console.WriteLine($"{card.value} {card.color}");
            }
            Console.WriteLine("\nSeconde deck:");
            foreach (Card card in deck2)
            {
                Console.WriteLine($"{card.value} {card.color}");
            }

            // Avec Lifo; sortir pour chaque des joueurs en meme temps une carte
            // comparer leur carte: quelle carte à l'identifiant le plus éléve au niveau de la valeur
            // le joueur qui a la carte la plus élévée prend les deux cartes et la met en bas de son paquet
            // en cas d'égalité 3 cartes 
        }
    }
}
