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
        public static int GetRandomInt(int min, int max) // N.B. min è compreso ma max no
        {
            if (min > max)
            {
                throw new RandomArgumentsException(); 
                // in questo caso solleva l'eccezione e il programma interrompe la normale esecuzione
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode(); //come seed si usa l'HashCode della Giud
                //Giud insieme pseudocasuale di 128 bit, che è impossibile si ripeta per 1 mld di anni
                //si usa per avere una stringa casuale ad esempio se serve che nomi non confliggano
                
                Random r = new Random(seed); //senza il seed avrebbe stampato numeri random nel range, ma tutti uguali
                return r.Next(min, max);
            }
           
        }
        public static int GetSameInt(int i) 
        {
            return i;
        }
        public static int ConvertBynaryToInt(string binaryString)
        {
            int len = binaryString.Length;
            int[] binary_Array = new int[len];

            // verify that binaryString contains ONLY "1" or "0"
            for (int i = len - 1; i >= 0; i--) // len -1 perchè voglio partire dall'ultimo elemento. Zero è compreso perchè è il primo elemento
            {
                if (binaryString[i] == '0' || binaryString[i] == '1')
                {
                    string bit_string = binaryString.Substring(i, 1);

                    binary_Array[len - i - 1] = Int32.Parse(bit_string);
                }
                else
                {
                    Console.WriteLine("This string can't be converted in a decimal number");
                    break;
                }
            }

            int tot = 0;

            for (int i = 0; i < len; i++) // vedi disegno
            {
                int binary_digit = binary_Array[i];
                tot += binary_digit * (int)(Math.Pow(2, i));
            }

            return tot;
        }
    }
}
