using System;

namespace Javanais
{
    //Réalisez un algorithme qui va permettre a l'utilisateur d'encodé une phrase, cette prhase sera analyser pour etre
    //transformée en javanais.après traitemement afficher la phrase traduite ensuite, faire la meme chose en sens inverse.
    //Encodez une phrase en javanais pour ensuite la traduire en francais.

    //Les règles du javanais :

    //   - On ajoute 'av' après chaque consonne ou groupe de consonnes(comme par exemple ch, cl, ph, tr,…) d’un mot.
    //   - Si le mot commence par une voyelle, on ajoute av devant cette voyelle.
    //   - On ne rajoute jamais av après la consonne finale d’un mot.

    //Exemple : Abraracourcix => Avabravaravacavourcavix

    class Program
    {
        static void Main(string[] args)
        {
            string message = "JAVANAIS CYPHER\nEncode(Enter 1)\nDecode(Enter 2)";
            string input;
            int n;
            do
            {
                Console.WriteLine(message);
                input = Console.ReadLine();
                message = "Write 1 (code) or 2 (decode)";
            } while (!int.TryParse(input, out n));

            switch (n)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("JAVANAIS ENCODER\nEnter your sentence to translate in Javanais: ");
                    input = Console.ReadLine();
                    string traduction = Structs.Encode(input); 
                    Console.WriteLine(traduction);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("JAVANAIS DECODER\nEnter your sentence: ");
                    input = Console.ReadLine();
                    traduction = Structs.Decode(input);
                    Console.WriteLine(traduction);
                    break;
            }
        }
    }
}
