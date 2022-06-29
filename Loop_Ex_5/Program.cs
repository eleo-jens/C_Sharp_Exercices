using System;

namespace Loop_Ex_5
{
    // comptez de 0 a 20,0 en augmentant de 0.1 en utilisant des doubles. Remarquez vous qqch ? N'affiche pas le ,0 ?
    internal class Program
    {
        static void Main(string[] args)
        {
            //mettre m decimal et non double sinon ca donne 5,151555465466 de longs chiffres apres la virgule
            for (decimal i = 0m; i <= 20m; i = i + 0.1m)
            {
                Console.WriteLine(i);
            }
        }
    }
}
