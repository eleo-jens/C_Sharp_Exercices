using System;

namespace Tableau_Ex_3
{
    //Demandez à l’utilisateur d’introduire deux nombres au clavier 
    //et faite l’addition de ces deux nombres en ne convertissant que
    //caractère par caractère. (Méthode «ToCharArray()» de la classe «string»).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Addition---");
            string input;
            do {
                Console.WriteLine("Indiquez un premier nombre: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out _));
            char[] nombre1 = input.ToCharArray();
            do
            {
                Console.WriteLine("Indiquez un deuxieme nombre: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out _));
            char[] nombre2 = input.ToCharArray();

            for 

        }
    }
}
