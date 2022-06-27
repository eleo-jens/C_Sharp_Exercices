using System;
using System.Text.RegularExpressions;

namespace Operateur_Ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // récupère l'input bban de l'utilisateur
            Console.WriteLine("--- Convertisseur de BBAN Belge en IBAN ---\nIndiquez votre numéro de compte bancaire BBAN: ");
            string input = Console.ReadLine();

            // recuperer les deux derniers chiffres du bban avec un substring
            string last_two = input.Substring(input.Length - 2, 2);
            //Console.WriteLine(last_two);

            //Concaténez les deux derniers chiffres 2 fois et le code BE0
            const string BE0 = "111400";
            string concatenated = last_two + last_two + BE0;
            //Console.WriteLine(concatenated);

            // conversion de la concatenation en long pour pouvoir faire des opérations mathématiques dessus
            long temp;
            bool isChecked = long.TryParse(concatenated, out temp);
            //Console.WriteLine(temp);

            // opération pour obtenir les deux premiers chiffres pour l'IBAN
            short beginning = (short)(98 - (temp % 97));
            //Console.WriteLine(beginning);

            // conversion de l'int obtenu en string
            string first_two_digit = beginning.ToString();

            // unification du tout pour la création de l'IBAN avec des espaces
            string iban = "BE" + first_two_digit + input;
            string space_iban = iban.Insert(4, " ");
            space_iban = space_iban.Insert(9, " ");
            space_iban = space_iban.Insert(14, " ");
            Console.WriteLine($"BBAN: {input} -> IBAN: {space_iban}");

            //ajuster avec la correction sur git pour prendre en compte le cas où first_two_digit est inférieur à 10, il faudra dans ce cas rajouter un 0, par exemple BE05
        }
    }
}
