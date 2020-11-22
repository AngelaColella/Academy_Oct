using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Triangolo : IFiguraGeometrica
    {
        private double l1;
        private double l2;
        private double l3;

        public Triangolo(double l1, double l2, double l3)
        {
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public double GetArea()
        {
            double p = (l1 + l2 + l3) / 2;
            return Math.Sqrt(p * (p - l1) * (p - l2) * (p - l3));
        }

        public double GetPerimetro()
        {
            return l1 + l2 + l3;
        }
    }
}
