using System;

namespace Loop_Ex_3
{
    //Calculer les n premiers nombres premiers avec une boucle for
    // NOT FINISHED
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Nombre Premier\nInserez un nombre entier:");
            //string input = Console.ReadLine();
            //while(!int.TryParse(input, out int _))
            //{
            //    Console.WriteLine("Inserez un nombre correct...");
            //}
            //int num = int.Parse(input);
            //double square = Math.Sqrt(num);

            //for (int i = 0; i <= square; i++)
            //{
            //    if (num == 0 || num == 1)
            //    {
            //        Console.WriteLine($"{num} n'est pas un nombre premier");
            //        break;
            //    }
            //    else if (num % square == 0)
            //    {
            //        Console.WriteLine($"{num} n'est pas un nombre premier car il est divisible par {square}");
            //        break;
            //    }
            //    else 
            //    {
            //        Console.WriteLine($"{num} est un nombre premier");
            //        break; 
            //    }
            //}

            Console.WriteLine("Nombre Premier\nInserez un nombre entier:");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out int _))
            {
                Console.WriteLine("Inserez un nombre correct...");
            }
            int num = int.Parse(input);
            int square = (int)Math.Sqrt(num);
            int n = 1;

            while (n < num)
            {
                int count = 0;
                n++;
                for (int i = 0; i <= square; i++)
                {
                    if (num % square == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine($" {num} ");
                }
            }
        }
    }
}
