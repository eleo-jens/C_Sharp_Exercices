﻿using System;
using System.Collections.Generic;

namespace Grand_Prix
{
    class Program
    {
        static void Main(string[] args)
        {
            Course grand_prix;
            grand_prix.nb_participant = 3;
            grand_prix.nb_tour = 5;
            grand_prix.distance = 3.629;

            Chrono_voiture voiture1 = new Chrono_voiture();
            Chrono_voiture voiture2 = new Chrono_voiture();
            Chrono_voiture voiture3 = new Chrono_voiture();

            function tour_voiture;
            tour_voiture.lancerCourse(grand_prix, voiture1, voiture2, voiture3);
        }
    }
}
