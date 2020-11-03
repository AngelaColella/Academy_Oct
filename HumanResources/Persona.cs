using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources
{
    public class Persona
    {
        protected String Nome;
        protected String Cognome; 
        protected int Eta;
        public string Indirizzo { get; set; }

        public Persona() //costruttore di default
        {
 
        }

        public Persona(string nome, string cognome) //altro costruttore 
        {
            Nome = nome; 
            Cognome = cognome; 
        }

        public override bool Equals(object obj)
        {
            Persona p = (Persona)obj; 
            // sto facendo un downcast perchè voglio che object diventi Persona

            return (this.Nome == p.Nome && this.Cognome == p.Cognome)
                
        }

        public override int GetHashCode()
        {
            String s = this.Nome + this.Cognome;
            return s.GetHashCode();

        }

        public Ruolo Inquadramento;

        public Persona(string nome, string cognome, Ruolo r) 
        {
            Nome = nome;
            Cognome = cognome;
            this.Inquadramento = r;
        }



        /* public String Nome { get; set; }
        public String Cognome { get; set; }
        public int Eta { get; set; }

        // private string Indirizzo { get; set; }

        protected string Indirizzo; 
        */
    }
}
