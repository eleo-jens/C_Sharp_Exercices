using System;

namespace Condition_Ex_3
{
    //TO DO: hierarchise les conditions pour pouvoir avoir : triangle rectangle isocele par exemple
    //Réalisez un programme, permettant à un mathématicien de connaitre la forme d'un triangle juste en encodant lui-même la taille deses 3 côtés.Le type du triangle doit correspondre aussi bien à la taille de ses côté, mais aussi à l'amplitude de ses angles. (Scalène, isocèle, équilatéral, acutangle, obtusangle, rectangle)Attention aux erreurs de données, le triangle doit être possible à représenter.
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("--- Determinez le type de votre triangle. --- \nAttention: notre programme est francophone indiquez 3 ou 9,25 par exemple.\nEntrez la longueur du côté 1: ");
            float cote1;
            bool isChecked = float.TryParse(Console.ReadLine(), out cote1);

            Console.WriteLine("Entrez la longueur du côté 2: ");
            float cote2;
            isChecked = float.TryParse(Console.ReadLine(), out cote2);
            if (cote2 > cote1)
            {
                float temp = cote1;
                cote1 = cote2;
                cote2 = temp;
            }

            Console.WriteLine("Entrez la longueur du côté 3: ");
            float cote3;
            isChecked = float.TryParse(Console.ReadLine(), out cote3);
            if (cote3 > cote1)
            {
                float temp = cote1;
                cote1 = cote3;
                cote3 = temp;
            }

            if (cote1 > cote2 + cote3)
            {
                Console.WriteLine("Ceci n'est pas un triangle afficheable");
            }
            else
            {
                Console.WriteLine($"Votre triangle avec les longueurs suivantes: {cote1} - {cote2} - {cote3} est: ");
                if (cote1 == cote2 && cote1 == cote3) Console.WriteLine("Equilatéral");
                else if (cote1 == cote2 || cote1 == cote3 || cote3 == cote2) Console.WriteLine("Isocèle");
                else if (cote1 * cote1 == cote2 * cote2 + cote3 * cote3) Console.WriteLine("Rectangle");
                else if (cote1 * cote1 > cote2 * cote2 + cote3 * cote3) Console.WriteLine("Obtusangle");
                else if (cote1 * cote1 < cote2 * cote2 + cote3 * cote3) Console.WriteLine("Acutangle");
                else Console.WriteLine("Scalène");
            }
        }
    }
}
