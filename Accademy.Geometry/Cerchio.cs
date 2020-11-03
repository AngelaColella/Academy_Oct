using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Cerchio : IFiguraGeometrica
    {
        private double raggio;
        public Cerchio(double raggio)
        {
            this.raggio = raggio;
        }
        public double GetArea()
        {
            return this.raggio * this.raggio * Math.PI;
        }
        public double GetPerimetro()
        {
            return 2 * this.raggio * Math.PI;
        }

    }
}
