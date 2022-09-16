using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_Delegate
{
    class Voiture
    {
        #region Champs
        private string _plaque;
        #endregion

        #region Propriétes
        public string Plaque {
            get {
                return _plaque;
            }

            private set {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentNullException();
                _plaque = value;
            }
        }
        #endregion

        #region Constructeurs
        public Voiture(string plaque)
        {
            this.Plaque = plaque;
        }
        #endregion

        #region Méthodes

        #endregion
    }
}
