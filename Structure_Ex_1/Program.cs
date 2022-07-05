using System;

namespace Structure_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Version sans structure
            //int[,] tableau = new int[5, 5];
            //int[,] tableau = { {1,0,0,0,0},
            //                   {0,2,0,0,0},
            //                   {0,0,3,0,0},
            //                   {0,0,0,4,0},
            //                   {0,0,0,0,5} };
            //int x;
            //int y;

            //for (x = 0; x < 5; x++)
            //{
            //    string ligne = "";
            //    for (y = 0; y < 5; y++)
            //    {
            //        ligne = ligne + tableau[x,y];
            //    }
            //    Console.WriteLine(ligne);
            //}
            #endregion

            #region Version avec structure
            const int TAILLE = 5;
            Nullable<Point>[,] tableau = new Nullable<Point>[TAILLE, TAILLE];
            //Point?[,] tableau = new Point?[5, 5];

            //Version de la diagonale moins optimisée
            //int i;
            //int j;
            //for (i = 0; i < 5; i++)
            //{
            //    for (j = 0; j < 5; j++)
            //    {
            //        if (i == j)
            //        {
            //            Point p;
            //            p.x = i + 1;
            //            p.y = i + 1;
            //            tableau[i, j] = p;
            //        }
            //    }
            //}


            // remplir la diagonale
            for (int i = 0; i < TAILLE; i++)
            {
                Point p;
                p.x = i + 1;
                p.y = i + 1;
                tableau[i, i] = p;
            }

            // affichage
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (tableau[i, j] is null)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        // si ce n'est pas null, je crée un nouveau point qui contient le point de mon emplacement en tableau
                        Point p = (Point)tableau[i, j];
                        Console.Write($"X:{p.x} - Y: {p.y}");
                    }
                }
                Console.WriteLine();
            }
            #endregion


        }
    }
}
