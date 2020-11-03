using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.GeometryAbstract
{
    public abstract class FiguraGeometrica
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();

        public string GetDescription()
        {
            Type t = this.GetType(); //N.B. questa classe eredita sempre da object 
            string myType = t.ToString();

            string description = "I am a: " + myType + "with Area: " + GetArea() + "Perimetro: " + GetPerimetro();

            // string description = "Area: " + GetArea() + "Perimetro: " + GetPerimetro();
            // definisco una variabile stringa e poi faccio la concatenazione di una stringa con il risultato di GetArea
            return description;
        }

    
}
}

