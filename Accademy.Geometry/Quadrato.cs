using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Quadrato : IFiguraGeometrica
    {
        private double lato; // dichiarazione di una variabile privata lato

        public Quadrato(double lato) //costruttore. Quando farò l'istanza a Quadrato, dovrò dare in input il lato
        {
            this.lato = lato; 
            
            // this serve per identificare l'istanza in cui mi trovo
            // vuole dire: lato è la variabile lato di questa istanza
        }

        public double GetArea()
        {
            return this.lato * this.lato;
        }
        public double GetPerimetro()
        {
            return 4 * this.lato;
        }

    }
}
