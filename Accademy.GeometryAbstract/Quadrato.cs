using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.GeometryAbstract
{
    public class Quadrato : FiguraGeometrica
    {
        private double lato; 

        public Quadrato(double lato) 
        {
            this.lato = lato;
        }

        public override double GetArea()
        {
            return this.lato * this.lato;
        }
        public override double GetPerimetro()
        {
            return 4 * this.lato;
        }
    }
}
