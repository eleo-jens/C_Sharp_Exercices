using System;

namespace Tableaux_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nb;

            Console.WriteLine("Nombre premier");

            do
            {
                Console.WriteLine("Veuillez saisir un nombre :");
                nb = int.Parse(Console.ReadLine());
            }
            while (nb <= 0);

            for (int count = 0, value = 2; count < nb; value++)
            {
                bool isPrime = true;

                int sqrt = (int)Math.Sqrt(value);

                for (int diviseur = 2; diviseur <= sqrt && isPrime; diviseur++)
                {
                    if (value % diviseur == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine(value);
                    count++;
                }
            }
        }
    }
}
