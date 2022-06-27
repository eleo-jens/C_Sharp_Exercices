using System;

namespace Operateur_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez indiquer un premier nombre: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int a))
            {
                Console.WriteLine("Veuillez introduire un second nombre: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out int b) && b != 0)
                {
                    //int division = a / b;
                    //Console.WriteLine(division);
                    //int modulo = a % b;
                    //Console.WriteLine(modulo);
                    //double precis = (double)a / b;
                    //Console.WriteLine(precis);
                    Console.WriteLine($"Division entière : {a / b} \t Modulo : {a % b} \t Division : {(double)a/b}");
                }
                else Console.WriteLine($"Le nombre {input} n'est pas valide");
            }
            else Console.WriteLine($"Le nombre {input} n'est pas valide");
        }
    }
}
