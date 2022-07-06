using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methode_Ex_2
{
    public struct EquationSecondDegre
    {
        public double A, B, C;

        public bool SolveEquation(out Nullable<double> x1, out Nullable<double> x2)
        {
            double delta = (B * B) - (4 * A * C);
            if (delta >= 0)
            {
                if (delta == 0) x2 = x1 = -B / (2 * A);
                else
                {
                    x1 = (-B - Math.Sqrt(delta)) / (2 * A);
                    x2 = (-B + Math.Sqrt(delta)) / (2 * A);
                }
                return true;
            }
            else
            {
                x2 = x1 = null;
                return false;
            }

            // Version de base non raccourcie
            //double delta = (B * B) - (4 * A * C);
            //if (delta == 0)
            //{
            //    x1 = -B / (2 * A);
            //    x2 = x1;
            //    return true;
            //}
            //else if (delta > 0)
            //{
            //    x1 = (-B - Math.Sqrt(delta)) / (2 * A);
            //    x2 = (-B + Math.Sqrt(delta)) / (2 * A);
            //    return true;
            //}
            //else
            //{
            //    x1 = null;
            //    x2 = null;
            //    return false;
            //}
        }
    }
}
