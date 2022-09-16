using System;

namespace OO_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture v1 = new Voiture("1-BE-ELEO");
            Voiture v2 = new Voiture("1-BE-654");
            Voiture v3 = new Voiture("1-BE-147");
            Voiture v4 = new Voiture("1-BE-258");
            Voiture v5 = new Voiture("1-BE-963");

            Carwash Schaerbeek = new Carwash();
            Schaerbeek.Traiter(v1);
            Schaerbeek.Traiter(v2);
            Schaerbeek.Traiter(v3);
            Schaerbeek.Traiter(v4);
            Schaerbeek.Traiter(v5);
        }
    }
}
