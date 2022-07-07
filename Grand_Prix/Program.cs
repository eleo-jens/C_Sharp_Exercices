using System;

namespace Grand_Prix
{
    class Program
    {
        static void Main(string[] args)
        {
            Course grand_prix;
            grand_prix.nb_participant = 3;
            grand_prix.nb_tour = 5;
            grand_prix.distance = 3629;

            Chrono_voiture tour = new Chrono_voiture();

            Random rnd = new Random();
            int vitesse = rnd.Next(tour.vitesse_min, tour.vitesse_max)



        }
    }
}
