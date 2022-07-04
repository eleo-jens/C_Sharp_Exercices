using System;

namespace Revision_Loop_Ex_5
{
    //Réalisez un algorithme permettant à un utilisateur d’obtenir la moyenne des températures.Les températures peuvent être des Celsius ou des Fahrenheit, le résultat doit toujours être en Celsius(trouvez une méthode pour reconnaitre l’un ou l’autre) Ne sachant pas combien de températures nos utilisateurs vont introduire, ceux-ci doivent renseigner le programme avec la commande ‘FIN’
    class Program
    {
        static void Main(string[] args)
        {
            string end = "FIN";
            string degre; 
            string input;
            int temperature = 0;

            do
            {
                do
                {
                    Console.WriteLine("Voulez-vous insérer une température en Celsius ou Fahrenheit: taper C ou F.");
                    degre = Console.ReadLine();
                } while (degre != "F" && degre != "C");

                do
                {
                    Console.WriteLine("Insérez une température. Pour en connaitre la moyenne tapez: FIN");
                    input = Console.ReadLine();
                } while (!float.TryParse(input, out _) && input != end);

                switch (degre)
                {
                    case "C":
                        int celsius = int.Parse(input);
                        temperature += celsius;
                        break;
                    case "F":
                        float fahrenheit = float.Parse(input);
                        celsius = (int)((fahrenheit - 32) * 5/9);
                        temperature += celsius;
                        break;
                    case "FIN":
                        Console.WriteLine($"La moyenne de vos températures est: {temperature}° Celsius");
                        break;
                }
            } while (input != end);
        }
    }
}
