using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Impiegato : Persona 
    {
        public string Matricola { get; set; } //proprietà

        public Impiegato() //costruttore
        {
            Indirizzo = "Via Roma";
        }
    }
}
