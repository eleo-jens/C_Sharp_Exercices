using System;

namespace Revision_Loop_Ex_5
{
    //Réalisez un algorithme permettant à un utilisateur d’obtenir la moyenne des températures.Les températures peuvent être des Celsius ou des Fahrenheit, le résultat doit toujours être en Celsius(trouvez une méthode pour reconnaitre l’un ou l’autre) Ne sachant pas combien de températures nos utilisateurs vont introduire, ceux-ci doivent renseigner le programme avec la commande ‘FIN’
    class Program
    {
        static void Main(string[] args)
        {
            string end = "FIN";
            string input;
            float temperature;

            do
            {
                Console.WriteLine("Insérer des températures en Celsius ou Fahrenheit. Pour en connaitre la moyenne tapez: FIN");
                input = Console.ReadLine();


            } while (word = end);
        }
    }
}
