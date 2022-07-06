using System;

namespace Methode_Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            EquationSecondDegre eq;  
            eq.A = 1;
            eq.B = -2;
            eq.C = 1;
            Nullable<double> x1, x2; 

            if(eq.SolveEquation(out x1, out x2))
            {
                Console.WriteLine($"L'équation {eq.A}x² + {eq.B}x + c est résolvable\nX1 vaut {x1}\nX2 vaut {x2}");
            }
            else
            {
                Console.WriteLine($"L'équation {eq.A}x² + {eq.B}x + c n'est pas résolvable");
            }
        }
    }
}
