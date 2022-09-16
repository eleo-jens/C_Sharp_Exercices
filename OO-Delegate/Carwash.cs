using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Delegate
{
    delegate void CarwashAction(Voiture voit);
    class Carwash
    {
        private CarwashAction _process;
        #region VERSION 1 - avec des méthodes non anonymes
        //public Carwash()
        //{
        //    _process = Preparer;
        //    _process += Laver;
        //    _process += Secher;
        //    _process += Finaliser;
        //}

        //private void Preparer(Voiture v)
        //{
        //    Console.WriteLine($"Je prépare la voiture: {v.Plaque}");
        //}

        //private void Laver(Voiture v)
        //{
        //    Console.WriteLine($"Je lave la voiture: {v.Plaque}");
        //}

        //private void Secher(Voiture v)
        //{
        //    Console.WriteLine($"Je sèche la voiture: {v.Plaque}");
        //}

        //private void Finaliser(Voiture v)
        //{
        //    Console.WriteLine($"Je finalise la voiture: {v.Plaque}");
        //}

        //public void Traiter(Voiture v)
        //{
        //    _process?.Invoke(v);
        //}
        #endregion

        #region VERSION 2 - avec des méthodes anonymes
        public Carwash()
        {
            _process = delegate (Voiture v) { Console.WriteLine($"Je prépare la voiture: {v.Plaque}"); };
            _process += delegate (Voiture v) { Console.WriteLine($"Je lave la voiture: {v.Plaque}"); };
            _process += delegate (Voiture v) { Console.WriteLine($"Je sèche la voiture: {v.Plaque}"); };
            _process += delegate (Voiture v) { Console.WriteLine($"Je finalise la voiture: {v.Plaque}"); };
        }

        public void Traiter(Voiture v)
        {
            _process?.Invoke(v);
        }
        #endregion
    }
}
