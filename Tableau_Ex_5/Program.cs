using System;

namespace Tableau_Ex_5
{
    // Une application de cryptage de messages à l'aide du Code de César
    // utilise un alphabet décalé: si le décalage est de 2, l'alphabet [A,B,C,D,E,...] est décalé de 2 lettres 
    // [C,D,E,F,G, ...]
    // Le message "Salut" devient alors "Ucnwv"
    class Program
    {
        static void Main(string[] args)
        {
            #region Version 1
            //string message = "Salut";
            //string code = "";
            //foreach (int letter in message)
            //{
            //    int decale = letter + 2;
            //    code = code + (char)decale;
            //}
            //Console.WriteLine(code);
            #endregion

            #region Version 2
            //Console.WriteLine("---Code de César---\nIndiquez un message à crypter:");
            //string message = Console.ReadLine();
            //string code = "";
            //foreach (int letter in message)
            //{
            //    int decale = letter + 2;
            //    code = code + (char)decale;
            //}
            //Console.WriteLine(code);
            #endregion

            #region Version 3 avec Tableau
            //Console.WriteLine("---Code de César---\nIndiquez un message à crypter:");
            //string input = Console.ReadLine();
            //char[] message = input.ToCharArray();
            //string code = "";
            //foreach (int letter in message)
            //{
            //    int decale = letter + 2;
            //    code = code + (char)decale;
            //}
            //Console.WriteLine(code);
            #endregion

            #region Version 4 cryptage
            //Console.WriteLine("---Code de César---\nIndiquez un message à crypter:");
            //string message = Console.ReadLine();
            //string input;
            //int i;
            //do {
            //    Console.WriteLine("Indiquez le nombre de décalage de lettre (entre 1 et 133)");
            //    input = Console.ReadLine();

            //} while (!int.TryParse(input, out i) || (i < 1 || i > 133)); 
            //string code = "";
            //foreach (int letter in message)
            //{
            //    int decale = letter + i;
            //    code = code + (char)decale;
            //}
            //Console.WriteLine(code);
            #endregion

            #region Version 4 Decryptage
            Console.WriteLine("---Code de César---\nIndiquez un message à décrypter:");
            string message = Console.ReadLine();
            string input;
            int i;
            do
            {
                Console.WriteLine("Indiquez le nombre de décalage de lettre (entre 1 et 133)");
                input = Console.ReadLine();

            } while (!int.TryParse(input, out i) || (i < 1 || i > 133));
            string code = "";
            foreach (int letter in message)
            {
                int decale = letter - i;
                code = code + (char)decale;
            }
            Console.WriteLine(code);
            #endregion
        }
    }
}
