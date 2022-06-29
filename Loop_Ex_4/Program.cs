using System;

namespace Loop_Ex_4
{
    //5e tables de multiplication allant jusque x20
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5 ; i++)
            {
                for (int n = 1; n <= 20 ; n++)
                {
                    Console.WriteLine($"{i} x {n} = {i*n}; ");
                }
                Console.WriteLine("---------------");
            }
        }
    }
}
