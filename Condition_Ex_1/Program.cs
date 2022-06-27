using System;

namespace Condition_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduisez un nombre, je vous dirai s'il est paire ou non: ");
            int nombre;
            string input = Console.ReadLine();
            if (int.TryParse(input, out nombre))
            {
                int moitie = nombre / 2;
                if (moitie * 2 == nombre)
                {
                    Console.WriteLine($"Le nombre {nombre} est paire");
                }
                else Console.WriteLine($"Le nombre {nombre} est impaire");
            }
            else Console.WriteLine("L'input est incorrecte...");
        }
    }
}
