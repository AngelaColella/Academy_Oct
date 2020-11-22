using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Impiegato : Persona 
    {
        public String Matricola { get; set; }

        public Impiegato()
            : base()
        {
            Indirizzo = "Via Verdi"; // non c'è bisgno di definire Indirizzo, perchè è nella classe Persona
        }

        public Impiegato(string nome, string cognome, int eta, string matricola)
            : base(nome, cognome)
        {
            Eta = eta;
            this.Matricola = matricola;
            Indirizzo = "Via Verdi";
        }

        public void StampaLettera(string testo)
        {
            string txt = testo.ToLower();
            Console.WriteLine(txt);
        }
    }
}
