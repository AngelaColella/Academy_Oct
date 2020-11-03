using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class RandomHelper
    {
        public static int RandomNumber(int n, int m)
        {
            
                Guid newgiud = Guid.NewGuid();

                /* insieme pseudocasuale di 128 bit, che è impossibile si ripeta per 1 mld di anni
                 * si usa per avere una stringa casuale ad esempio se serve che nomi non confliggano
                 */

                int hash = newgiud.GetHashCode();
                int seed = hash;
                Random r = new Random(seed);
                int randomInt = r.Next(n, m);
                return randomInt;


                //Random r = new Random();
                //int rInt = r.Next(n, m);
                //return rInt;

        }
    }
}
