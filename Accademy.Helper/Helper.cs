using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class Helper
    {
        /// <summary>
        /// Get a random value in a range
        /// </summary>
        /// <param name="min">min range value</param>
        /// <param name="max">max range value</param>
        /// <exception cref="Accademy.Helper.RandomArgumentsException">Thrown when min value is greater then max value</exception>
        /// <returns>random int in a range</returns>
        public static int GetRandomInt(int min, int max)
        {
            if (min > max)
            {
                throw new RandomArgumentsException(); 
                // in questo caso solleva l'eccezione e il programma interrompe la normale esecuzione
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode();
                Random r = new Random(seed);
                //Random r = new Random();
                return r.Next(min, max);
            }

        }

    }
}
