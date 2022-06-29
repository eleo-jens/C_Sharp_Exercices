using System;

namespace Loop_Ex_1
{
    //NOT FINISHED: inserer une verification si inferieur a 0
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suite de Fibonacci\nInserez un nombre entier: ");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int _))
            {
                Console.WriteLine("Inserez un nombre entier correct...");
            }
            int num = int.Parse(input);

            int first = 0;
            int second = 1;
            int next_number;
            string suite = "";
            for (int i = 0; i <= num; i++)
            {
                next_number = first + second;
                first = second;
                second = next_number;
                suite = suite + $"{next_number}" + " ";
            }
            Console.WriteLine(suite);
        }
    }
}
