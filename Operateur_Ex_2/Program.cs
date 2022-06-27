using System;
using System.Linq;

namespace Operateur_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificateur de compte bancaire\nIndiquez votre numéro de compte BBAN (12 chiffres): ");
            string input = Console.ReadLine();

            // Pas necessaire: car dans les formulaires les espaces et tirets sont des effets visuels: leRemove all whitespace from the string: concatene les caractères qui ne sont pas des espaces blancs avec using System.Linq;
            string bban = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));

            // Vérification: on vérifie la longueur et on vérifie ce sont bien des chiffres (long) : ici on a pas besoin du résultat du TryParse, on doit juste voir si le bban est transformable on met out _, vu que la valeur a déjà été vérifiée on pourra par la suite utiliser simplement le Parse
            if (bban.Length == 12 && long.TryParse(bban, out _))
            {
                //Get the two last digits with substrings: where we want to start the substring, how many caracters we want in the substring
                // on met que le point de départ donc il va jusqu'à la fin, dans l'autre on met le début et la taille
                string last_two = bban.Substring(10);
                // verifier s'il se termine par 00, 98, 99 dans ce cas il n'est pas correcte, autrement on peut continuer la vérification
                if (last_two == "00" || last_two == "98" || last_two == "99") Console.WriteLine("KO");
                else
                {
                    string ten_first = bban.Substring(0, 10);

                    //Conversion of the ten digit long string into a long
                    long ten_digit = long.Parse(ten_first);

                    //Conversion of the two digit long strind int a short
                    short two_digit = short.Parse(last_two);

                    //Verification of the BBAN with the modulo
                    if (ten_digit % 97 == two_digit || (ten_digit % 97 == 0 && two_digit == 97))
                    {
                        Console.WriteLine("OK");
                    }
                    else Console.WriteLine("KO");
                }
            }
            else Console.WriteLine($"Votre numéro BBAn '{bban}' ne semble pas valide...");



        }
    }
}
