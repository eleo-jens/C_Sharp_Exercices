﻿using System;
using System.Collections.Generic;

namespace Tableaux_Ex_1
{
    //Grâce à une boucle «while» et à l’aide d’une collection, 
    //calculez les nombres premiers inférieur à un nombre entier entré au clavier.
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

            Queue<int> Premiers = new Queue<int>();

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
                    Premiers.Enqueue(value);
                    Console.WriteLine("{0}", Premiers.Dequeue());
                    count++;
                }
            }
        }
    }
}
