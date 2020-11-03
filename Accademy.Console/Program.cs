//using Accademy.Geometry;
using Accademy.GeometryAbstract;
using Accademy.Helper;
using HumanResources;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Accademy.Console
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //TestGeometry();
            //TestHR();
            //TestGeometryAbstract();
            //TestLoops();
            //TestRandomHelper();
            //TestHelper();
            TestGeneric();

        }

        private static void TestGeneric()
        {
            List<int> lst_int = new List<int>() { 1,2,3,4,5,6,7,8,9,0 };
            if(lst_int.Contains(3))
                System.Console.WriteLine("3 is int List");
            
            List<Persona> lst_persona = new List<Persona>();
            Persona mario = new Persona("Mario", "Rossi");
            Persona maria = new Persona("Maria", "Bianchi");
            Persona gianni = new Persona("Mario", "Giallo");

            lst_persona.Add(mario);
            lst_persona.Add(maria);
            lst_persona.Add(gianni);

            Persona p = new Persona("Mario", "Rossi");

            if(lst_persona.Contains(p))
                System.Console.WriteLine("Persona is in list");
            else
                System.Console.WriteLine("Persona is NOT in list");

            System.Console.WriteLine(p.Equals(mario));
            // restituisce false perchè p e mario sono due puntatori diversi
            // sono due istanze diverse


            System.Console.WriteLine(p.GetHashCode());
            System.Console.WriteLine(mario.GetHashCode());
            // voglio che anche il codice hash sia lo stesso, quindi inserisco un altro
            // metodo nella classe persona

        }

        private static void TestHelper()
        {
            String dir = @"D:\temp";
            String filename = "accademy_random.txt";
            String path = System.IO.Path.Combine(dir, filename);

            int min = 1001;
            int max = 1000;

            System.IO.StreamWriter accademy_randomFile = new System.IO.StreamWriter(path);
            for (int i = 0; i < 50; i++)
            {
                try
                {
                    accademy_randomFile.WriteLine(Accademy.Helper.Helper.GetRandomInt(min, max)); // se tutto va bene, non si entra nel catch
                }
                catch (RandomArgumentsException excp)
                {
                    System.Console.WriteLine(excp.Message);
                    break; // esce dal ciclo for
                }
            }

            accademy_randomFile.Close();

            System.IO.StreamReader file = new System.IO.StreamReader(path);
            string line;
            while ((line = file.ReadLine()) != null)
            {
                int randomInt = 0;
                try
                {
                    randomInt = Int32.Parse(line);
                }
                catch (FormatException excp)
                {
                    System.Console.WriteLine(excp.Message);
                }
                System.Console.WriteLine(randomInt + 1000);
            }
            file.Close();
            System.Console.ReadLine();
        }

    }

        //private static void TestRandomHelper()
        //{
        //    System.Console.WriteLine("Enter a number:");
        //    int n1 = Convert.ToInt32(System.Console.ReadLine());

        //    System.Console.WriteLine("Enter another number:");
        //    int n2 = Convert.ToInt32(System.Console.ReadLine());

        //    if (n1 > n2)
        //    {
        //        System.Console.WriteLine("Error: The second number must be higher than the second");
        //        System.Console.ReadLine();
        //    }
        //    else
        //    {
        //        StreamWriter file = new StreamWriter(@"C:\Users\angela.colella\Documents\Angela\Random.txt");

        //        for (int i = 0; i < 100; i++)
        //        {
        //            int num = RandomHelper.RandomNumber(n1, n2);
        //            file.WriteLine(num);
        //        }

        //        file.Close();

        //        StreamReader sr = new StreamReader(@"C:\Users\angela.colella\Documents\Angela\Random.txt");
        //        String line = sr.ReadLine();

        //        while (line != null)
        //        {
        //            System.Console.WriteLine(line);
        //            line = sr.ReadLine();
        //        }

        //        sr.Close();
        //        System.Console.ReadLine();

        //    }

        //    ////int n1 = 100;
        //    ////int n2 = 1000;

        //    //StreamWriter file = new StreamWriter(@"C:\Users\angela.colella\Documents\Angela\Random.txt");

        //    //for (int i = 0; i < 100; i++)
        //    //{
        //    //    int num = RandomHelper.RandomNumber(n1, n2);
        //    //    file.WriteLine(num);
        //    //}

        //    //file.Close();


        //    //StreamReader sr = new StreamReader(@"C:\Users\angela.colella\Documents\Angela\Random.txt");
        //    //String line = sr.ReadLine();



        //    //while (line != null)
        //    //{
        //    //    int randomInt = 0;
        //    //    try
        //    //    {
        //    //        randomInt = Int32.Parse(line);
        //    //    }
        //    //    catch (FormatException excp) 
        //    //    {

        //    //        System.Console.WriteLine(excp.Message);
        //    //    }

        //    //    // int randomInt = Int32.Parse(line)
        //    //    // se vado a modificare il file e inserisco una stringa al posto di un numero,
        //    //    // con questa linea di codice, il programma se ne accorgerà e si bloccherà perchè
        //    //    // trovera un'eccezione non gestita. Come gestirla?
        //    //    // seleziono la riga che mi dà l'eccezione', snippet, surrond with, try, invio

        //    //    System.Console.WriteLine(line);
        //    //    line = sr.ReadLine();
        //    //}

        //    //sr.Close();
        //    //System.Console.ReadLine();

        //    ///* int n1 = 100;
        //    //int n2 = 1000;

        //    //String dir = @"C:\Users\angela.colella\Documents\Angela";
        //    //String filename = "Rand";
        //    //String path = dir + @"\" + filename;

        //    //StreamWriter file = new StreamWriter(Path.Combine(dir, filename));

        //    //    for (int i = 0; i < 100; i++)
        //    //    {
        //    //        int num = RandomHelper.RandomNumber(n1, n2);
        //    //        file.WriteLine(num);
        //    //    }

        //    //file.Close();
        //    //StreamReader file = new StreamReader(path);
        //    //*/
        //}

        //private static void TestLoops()
        //{
        //    // declare string s = "ahaah"
        //    // transform s in char array
        //    // use for loop to invert array chars


        //   // string s = "Ciao";
        //   // char[] charArr = s.ToCharArray();
        //   // int len = charArr.Length;
        //   // char[] newArr = new char[len];
            

        //   //for (int i = 0; i < len; i++)
        //   // {
        //   //     newArr[len -1 -i] = charArr[i];
        //   // }


        //   // dichiaro lista di caratteri
        //   // for per inserire nella lista 10 caratteri
        //   // dichiarare array di char della stessa lunghezza della lista
        //   // ciclo foreach sulla prima lista per fare inserimento inverso nell'array
        //   // trasformare array in una lista 
        //   // foreach sulla seconda lista (quella in ordine inverso) per stampare i caratteri
      

        //    List<char> charList = new List<char>();

        //    for (int i = 65; i < 75 ; i++) // i numeri fanno riferimento al codice ASCII
        //    {
        //        charList.Add(Convert.ToChar(i));
        //    }

        //    char[] newCharArray = new char[charList.Count];
        //    int j = charList.Count -1;

        //    foreach (char c in charList)
        //    {
        //        newCharArray[j] = c;
        //        j--;
        //    }

        //    List<char> newList = newCharArray.ToList();

        //    foreach (char c in charList)
        //    {
        //        System.Console.WriteLine(c);
        //    }

        //}

        //private static void TestGeometryAbstract()
        //{
        //    Quadrato q1 = new Quadrato(11.009);
        //    Cerchio c1 = new Cerchio(9.25);
        //    PrintFiguraAbstract(q1);
        //    PrintFiguraAbstract(c1);

        //}

        //private static void PrintFiguraAbstract(FiguraGeometrica f)
        //{
        //    string s = f.GetDescription();
        //    System.Console.WriteLine(s);
        //}

    /*
    private static void TestHR()
    {
        Persona mario = new Persona();

        // mario.Nome = "Mario";
        // mario.Cognome = "Rossi";

        Impiegato imp = new Impiegato();

        // mario.SetIndirizzo("Via Tutti");
        // imp.SetIndirizzo("Via Via");

    }

    private static void TestGeometry()
    {
        Quadrato q1 = new Quadrato(12.98); // istanzia un quadrato
        Cerchio c1 = new Cerchio(11.75);
        //Rettangolo r1 = new Rettangolo(11.77, 33.9);

        PrintFigura(q1);
        PrintFigura(c1);
        //PrintFigura(r1);

    }

    private static void PrintFigura(IFiguraGeometrica f)
        //qui stiamo passando un'istanza che implementa un'interfaccia
    {
        System.Console.WriteLine("Area {0}, Perimetro {1}", f.GetArea(), f.GetPerimetro());
    }

   /* private static void PrintCerchio(Cerchio c1)
    {
        System.Console.WriteLine("Area {0}, Perimetro {1}", c1.GetArea(), c1.GetPerimetro());
    }

    private static void PrintQuadrato(Quadrato q1)
    {
        System.Console.WriteLine("Area {0}, Perimetro {1}", q1.GetArea(), q1.GetPerimetro());
    }
   */
}
