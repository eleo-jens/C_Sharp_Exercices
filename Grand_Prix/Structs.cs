using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Prix
{
    public struct Course
    {
        public int nb_participant;
        public int nb_tour;
        public double distance;
    }

    public struct Chrono_voiture
    {
        public string piloteName;
        public List<double> chronos;
        public int vitesse_min;
        public int vitesse_max;
    }

    public struct function // pas un bon nom porte à confusion
    {
        public double VoitureRoule(Chrono_voiture voiture, Course grand_prix)
        {
            Random rnd = new Random();
            voiture.vitesse_min = 80;
            voiture.vitesse_max = 120;
            double vitesse = rnd.Next(voiture.vitesse_min, voiture.vitesse_max);

            //convertisseur km/h en m/s diviser par 3.6
            vitesse = vitesse / 3.6;
            grand_prix.distance = grand_prix.distance * 1000;

            //calculer le chrono en seconde
            double chrono = grand_prix.distance / vitesse;

            //voiture.chronos = new List<double>();
            //voiture.chronos.Add(chrono);
            return chrono;
        }

        public void CreerCourse(Course grand_prix, Chrono_voiture voiture1, Chrono_voiture voiture2, Chrono_voiture voiture3)
        {
            Console.WriteLine("Lancement du Grand Prix !");

            voiture1.chronos = new List<double>();
            voiture2.chronos = new List<double>();
            voiture3.chronos = new List<double>();
            Chrono_voiture[] voitures = new Chrono_voiture[] { voiture1, voiture2, voiture3 };

            DemarrerCourse(voitures, grand_prix);

            Dictionary<double,string> podium = new Dictionary<double,string>();
            
            for (int i = 0; i < voitures.Length; i++)
            {
                podium.Add(voitures[i].chronos.Sum(),voitures[i].piloteName);
            }
            List<double> chronos = new List<double>();
            chronos = podium.Keys.ToList();
            
            chronos.Sort();
            chronos.Reverse();

            Console.WriteLine("\nPODIUM");
            for (int i = 0; i < chronos.Count; i++)
            {
                string message = $"N°{i + 1} : {podium[chronos[i]]} : {chronos[i]}";
                
                if (i == 0)
                {
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine($"{message} : {chronos[i] - chronos[0]}");
                }
            }
        }

        public void DemarrerCourse(Chrono_voiture[] voitures, Course grand_prix)
        {
            int tour = 0;
            while (tour < grand_prix.nb_tour)
            {
                Console.WriteLine($"\nTour {tour + 1}");
                function tour_voiture;

                for (int i = 0; i < voitures.Length; i++)
                {
                    double chrono = tour_voiture.VoitureRoule(voitures[i], grand_prix);
                    voitures[i].chronos.Add(chrono);

                    Console.WriteLine($"{voitures[i].piloteName} {voitures[i].chronos[tour]} secondes");
                }
                tour++;
            }
        }
    }


    // probleme dans syntaxe pour la liste parametre d'une instance
    //public void afficherPodium(List<double> podium, List<double> Chrono_voiture.chronos , List<double> Chrono_voiture2, List<double> Chrono_voiture3)
    //{
    //    double chrono1 = voiture1.chronos.Sum();
    //    podium.Add(chrono1);

    //    double chrono2 = voiture2.chronos.Sum();
    //    podium.Add(chrono2);

    //    double chrono3 = voiture3.chronos.Sum();
    //    podium.Add(chrono3);
    //    podium.Sort();
    //    podium.Reverse();

    //    Console.WriteLine("PODIUM");
    //    for (int i = 0; i < podium.Count; i++)
    //    {
    //        string message = "";
    //        if (podium[i] == chrono1)
    //        {
    //            message = $"N°{i + 1} : Participant 1 : {podium[i]}";
    //        }
    //        else if (podium[i] == chrono2)
    //        {
    //            message = $"N°{i + 1} : Participant 2 : {podium[i]}";
    //        }
    //        else
    //        {
    //            message = $"N°{i + 1} : Participant 3 : {podium[i]}";
    //        }

    //        if (i == 0)
    //        {
    //            Console.WriteLine(message);
    //        }
    //        else
    //        {
    //            Console.WriteLine($"{message} : {podium[i] - podium[0]}");
    //        }
    //    }
    //}

    //afficherTour() Ceci est à mettre dans une fonction à part qui sera appelée par lancerCourse afin d'afficher les chronos pour chaque tour et voiture
    //int n1 = voiture1.chronos.Count;
    //for (int i = 0; i < n1; i++)
    //{
    //    Console.WriteLine(voiture1.chronos[i]);
    //}
    //int n2 = voiture2.chronos.Count;
    //for (int i = 0; i < n2; i++)
    //{
    //    Console.WriteLine(voiture2.chronos[i]);
    //}
    //int n3 = voiture3.chronos.Count;
    //for (int i = 0; i < n3; i++)
    //{
    //    Console.WriteLine(voiture3.chronos[i]);
    //}
}
